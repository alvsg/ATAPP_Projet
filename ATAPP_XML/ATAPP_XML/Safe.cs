/*
 * PROJET : Bilbio-tech
 * AUTEUR : ALVES GUASTTI Letitia (I.FA-P3A)
 * DESC. : Un gestionnaire de mot de passe
 * VERSION : 26.01.2021 v.1
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //Added

namespace ATAPP_XML
{
    class Safe
    {
        private List<Record> _safe;
        private List<int> _addedInXmlFile, _modifiedInXmlFile;
        private Record _newRecord;
        FileXML file;
        Button btnRecord;
        frmMain frmMain;

        internal List<Record> Coffre { get => _safe; set => _safe = value; }
        public List<int> AddedInXmlFile { get => _addedInXmlFile; }
        public List<int> ModifiedInXmlFile { get => _modifiedInXmlFile; }
        public Record NewRecord { get => _newRecord; set => _newRecord = value; }

        public Safe(frmMain frm)
        {
            frmMain = frm;
            file = new FileXML();
            _safe = file.GetDataInArray(); // ATTENTION /!\ FAILLE MAJEUR : Toutes les données du fichier xml présente dans cette liste sont visible en claire dans la mémoire !
            _addedInXmlFile = new List<int>();
            _modifiedInXmlFile = new List<int>();
        }

        public Safe()
        {

        }

        /// <summary>
        /// Méthode qui permet d'ouvrir un formulaire affichant les données du bouton cliquer et permettant de les modifier 
        /// </summary>
        /// <param name="button"></param>
        public void ShowAndLetModifyValuesInData(Button button)
        {
            Record record = _safe.Where(nameOf => nameOf.Name == button.Name).First();
            int index = _safe.IndexOf(record);
            frmForm frmFormModifiedInXmlFile = new frmForm(record, "ShowData");
            frmFormModifiedInXmlFile.ShowDialog();
            if (frmFormModifiedInXmlFile.DialogResult == DialogResult.OK)
            {
                Secure pwd = new Secure();
                _safe[index] = new Record(frmFormModifiedInXmlFile.Enregistrement.Username, frmFormModifiedInXmlFile.Enregistrement.Password, frmFormModifiedInXmlFile.Enregistrement.Name);
                _modifiedInXmlFile.Add(index);
                pwd.addInFile(frmMain.Key, this);
            }
        }

        /// <summary>
        /// Méthode qui permet d'ajouter des données dans la liste de donnée
        /// </summary>
        public void AddValuesInData()
        {
            frmForm frmFormAddInXmlFile = new frmForm("Ajouter");
            frmFormAddInXmlFile.ShowDialog();
            if (frmFormAddInXmlFile.DialogResult == DialogResult.OK)
            {
                Secure pwd = new Secure();
                _newRecord = new Record();

                _newRecord.Name = frmFormAddInXmlFile.Enregistrement.Name;
                _newRecord.Username = frmFormAddInXmlFile.Enregistrement.Username;
                _newRecord.Password = frmFormAddInXmlFile.Enregistrement.Password;

                _safe.Add(_newRecord);

                int index = _safe.IndexOf(_newRecord);
                _addedInXmlFile.Add(index);
            }
        }

        /// <summary>
        /// Méthode qui permet de mettre à jour l'affichage du formulaire
        /// </summary>
        /// <param name="flpDataValueAsButton"></param>
        public void UpdateOnLoad(FlowLayoutPanel flpDataValueAsButton)
        {
            foreach (Record record in _safe)
            {
                CreateButton(record, flpDataValueAsButton);
            }
        }

        private void btnFlp_Click(object sender, EventArgs e)
        {
            if (sender is Button btnRecord)
            {
                ShowAndLetModifyValuesInData(btnRecord);
            }
        }

        public void CreateButton(Record record, FlowLayoutPanel flpDataValueAsButton)
        {
            btnRecord = new Button();
            btnRecord.Name = record.Name;
            btnRecord.Text = record.Name;
            btnRecord.FlatStyle = FlatStyle.Flat;
            btnRecord.Width = 167;
            btnRecord.Height = 79;
            btnRecord.Click += btnFlp_Click;
            flpDataValueAsButton.Controls.Add(btnRecord);
        }
    }
}
