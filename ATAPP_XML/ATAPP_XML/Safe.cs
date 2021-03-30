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
        FileXML file;
        Button btnRecord;

        public List<Record> Coffre { get => _safe; set => _safe = value; }
        public List<int> AddedInXmlFile { get => _addedInXmlFile; }
        public List<int> ModifiedInXmlFile { get => _modifiedInXmlFile; }

        public Safe()
        {
            file = new FileXML();
            _safe = file.GetDataInArray(); // ATTENTION /!\ FAILLE MAJEUR : Toutes les données du fichier xml présente dans cette liste sont visible en claire dans la mémoire !
            _addedInXmlFile = new List<int>();
            _modifiedInXmlFile = new List<int>();
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
                _safe[index] = new Record(frmFormModifiedInXmlFile.Enregistrement.Username, frmFormModifiedInXmlFile.Enregistrement.Password, frmFormModifiedInXmlFile.Enregistrement.Name);
                _modifiedInXmlFile.Add(index);
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
                Record record = new Record();

                record.Name = frmFormAddInXmlFile.Enregistrement.Name;
                record.Username = frmFormAddInXmlFile.Enregistrement.Username;
                record.Password = frmFormAddInXmlFile.Enregistrement.Password;

                _safe.Add(record);

                int index = _safe.IndexOf(record);
                _addedInXmlFile.Add(index);
            }
        }

        /// <summary>
        /// Méthode qui permet de mettre à jour l'affichage du formulaire
        /// </summary>
        /// <param name="flpDataValueAsButton"></param>
        public void UpdateViewOfSafe(FlowLayoutPanel flpDataValueAsButton)
        {
            foreach (Record record in _safe)
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

        private void btnFlp_Click(object sender, EventArgs e)
        {
            if (sender is Button btnRecord)
            {
                ShowAndLetModifyValuesInData(btnRecord);
            }
        }
    }
}
