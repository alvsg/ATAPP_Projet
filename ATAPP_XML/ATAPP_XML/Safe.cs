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
        private List<int> _addedInXmlFile, _modifiedInXmlFile, _deletedInXmlFile;
        private List<string> _logos;
        private Record _newRecord;
        private int _noDonnee;
        private bool _cancel;
        private FlowLayoutPanel _flpButton;

        FileXML file;
        Button btnRecord;
        frmMain frmMain;

        internal List<Record> Coffre { get => _safe; set => _safe = value; }
        public List<int> AddedInXmlFile { get => _addedInXmlFile; set => _addedInXmlFile = value; }
        public List<int> ModifiedInXmlFile { get => _modifiedInXmlFile; set => _modifiedInXmlFile = value; }
        public Record NewRecord { get => _newRecord; set => _newRecord = value; }
        public int NoDonnee { get => _noDonnee; set => _noDonnee = value; }
        public bool Cancel { get => _cancel; }
        public List<int> DeletedInXmlFile { get => _deletedInXmlFile; set => _deletedInXmlFile = value; }
        public FlowLayoutPanel FlpButton { get => _flpButton; }
        public List<string> Logos { get => _logos; set => _logos = value; }

        /// <summary>
        /// Constructeur principal de la classe Safe qui prends la form principal en paramètre
        /// </summary>
        /// <param name="frm"> FrmMain </param>
        public Safe(frmMain frm)
        {
            frmMain = frm;
            file = new FileXML();
            _safe = file.GetDataInArray();
            _noDonnee = _safe.Count;
            _addedInXmlFile = new List<int>();
            _modifiedInXmlFile = new List<int>();
            _deletedInXmlFile = new List<int>();

            _logos = new List<string>();
            _logos.Add("airbnb.png");
            _logos.Add("aliexpress.png");
            _logos.Add("amazon.png");
            _logos.Add("burger king.png");
            _logos.Add("debian.png");
            _logos.Add("deezer.png");
            _logos.Add("discord.png");
            _logos.Add("disney +.png");
            _logos.Add("ebay.png");
            _logos.Add("epic games.png");
            _logos.Add("facebook.png");
            _logos.Add("figma.png");
            _logos.Add("genshin impact.png");
            _logos.Add("github.png");
            _logos.Add("gitlab.png");
            _logos.Add("gmail.png");
            _logos.Add("hp.png");
            _logos.Add("icon8.png");
            _logos.Add("instagram.png");
            _logos.Add("internet.png");
            _logos.Add("league of legends.png");
            _logos.Add("linkedin.png");
            _logos.Add("mcdonalds.png");
            _logos.Add("minecraft.png");
            _logos.Add("moodle.png");
            _logos.Add("netflix.png");
            _logos.Add("nordvpn.png");
            _logos.Add("nvidia.png");
            _logos.Add("origin.png");
            _logos.Add("paypal.png");
            _logos.Add("pinterest.png");
            _logos.Add("prime video.png");
            _logos.Add("ps3.png");
            _logos.Add("ps5.png");
            _logos.Add("razer.png");
            _logos.Add("reddit.png");
            _logos.Add("rockstar games.png");
            _logos.Add("slack.png");
            _logos.Add("snapchat.png");
            _logos.Add("soundcloud.png");
            _logos.Add("spotify.png");
            _logos.Add("starbucks.png");
            _logos.Add("steam.png");
            _logos.Add("telegramme.png");
            _logos.Add("tik tok.png");
            _logos.Add("tinder.png");
            _logos.Add("tripadvisor.png");
            _logos.Add("tumblr.png");
            _logos.Add("twitch.png");
            _logos.Add("twitter.png");
            _logos.Add("uber eats.png");
            _logos.Add("ubuntu.png");
            _logos.Add("uplay.png");
            _logos.Add("wakanim.png");
            _logos.Add("webtoon.png");
            _logos.Add("xiaomi.png");
            _logos.Add("youtube.png");
        }

        public Safe()
        {

        }

        /// <summary>
        /// Méthode qui permet d'ouvrir un formulaire affichant les données du bouton cliquer et permettant de les modifier 
        /// </summary>
        /// <param name="button"> Un bouton qui se trouve sur la frmMain </param>
        private void ShowAndLetModifyValuesInData(int index)
        {
            Record record = _safe[index];
            Secure pwd = new Secure();
            frmForm frmFormModifiedInXmlFile = new frmForm(record, "ShowData", Coffre);
            frmFormModifiedInXmlFile.ShowDialog();
            // Boucle qui permet de vérifier le résultat de la boite de dialogue du formulaire frmForm
            if (frmFormModifiedInXmlFile.DialogResult == DialogResult.OK)
            {
                updateButton(index, frmFormModifiedInXmlFile.Enregistrement.Name);
                _safe[index] = new Record(frmFormModifiedInXmlFile.Enregistrement.Username, frmFormModifiedInXmlFile.Enregistrement.Password, frmFormModifiedInXmlFile.Enregistrement.Name);
                _modifiedInXmlFile.Add(index);
            }
            else if (frmFormModifiedInXmlFile.DialogResult == DialogResult.Abort)
            {
                foreach(Button btn in _flpButton.Controls)
                {
                    if (index == _flpButton.Controls.IndexOf(btn))
                    {
                        _flpButton.Controls.RemoveAt(index);
                        _deletedInXmlFile.Add(index);
                    }
                }
            }
            pwd.addInFile(frmMain.Key, this);
        }

        /// <summary>
        /// Méthode qui permet d'ajouter des données dans la liste de donnée
        /// </summary>
        public void AddValuesInData()
        {
            frmForm frmFormAddInXmlFile = new frmForm("Ajouter");
            frmFormAddInXmlFile.ShowDialog();
            // Boucle qui permet de vérifier le résultat de la boite de dialogue du formulaire frmForm
            if (frmFormAddInXmlFile.DialogResult == DialogResult.OK)
            {
                _cancel = false;

                Secure pwd = new Secure();
                _newRecord = new Record();

                _newRecord.Name = frmFormAddInXmlFile.Enregistrement.Name;
                _newRecord.Username = frmFormAddInXmlFile.Enregistrement.Username;
                _newRecord.Password = frmFormAddInXmlFile.Enregistrement.Password;

                _safe.Add(_newRecord);

                int index = _safe.IndexOf(_newRecord);
                _addedInXmlFile.Add(index);
            }
            else
            {
                _cancel = true;
            }
        }

        /// <summary>
        /// Méthode qui permet de mettre à jour l'affichage du formulaire
        /// </summary>
        /// <param name="flpDataValueAsButton"></param>
        public void UpdateOnLoad(FlowLayoutPanel flpDataValueAsButton)
        {
            // Boucle qui parcourt les entrées utilisateurs dans la liste du coffre fort
            foreach (Record record in _safe)
            {
                CreateButton(record, flpDataValueAsButton);
            }
        }

        /// <summary>
        /// Méthode qui permet de lancer la méthode qui ouvre un formulaire affichant un formulaire de modification lors du clique du bouton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFlp_Click(object sender, EventArgs e)
        {
            // Boucle qui vérifie que le sender est bien un bouton
            if (sender is Button btnRecord)
            {
                ShowAndLetModifyValuesInData((int)btnRecord.Tag);
            }
        }

        /// <summary>
        /// Méthode qui permet de céer un bouton après avoir ajouter une entrée
        /// </summary>
        /// <param name="record"> Les entées de l'utilisateur </param>
        /// <param name="flpDataValueAsButton"> Le flowLayoutPanel de la frmMain </param>
        public void CreateButton(Record record, FlowLayoutPanel flpDataValueAsButton)
        {
            _flpButton = flpDataValueAsButton;

            btnRecord = new Button();
            btnRecord.Name = record.Name;
            string logoAChercher = btnRecord.Name + ".png";
            foreach(string logo in _logos)
            {
                if(logoAChercher.Equals(logo, StringComparison.CurrentCultureIgnoreCase))
                {
                    btnRecord.Image = (System.Drawing.Bitmap)Properties.Resources.ResourceManager.GetObject(logo);
                }
            }
            btnRecord.TextImageRelation = TextImageRelation.ImageAboveText;
            btnRecord.Text = record.Name;
            btnRecord.FlatStyle = FlatStyle.Flat;
            btnRecord.Width = 167;
            btnRecord.Height = 79;
            btnRecord.Click += btnFlp_Click;
            btnRecord.Tag = _safe.IndexOf(record);
            flpDataValueAsButton.Controls.Add(btnRecord);
        }

        public void updateButton(int index, string newName)
        {
            Button button = (Button)_flpButton.Controls[index];
            if(button.Text != newName)
            {
                button.Text = newName;
            }
        }
    }
}
