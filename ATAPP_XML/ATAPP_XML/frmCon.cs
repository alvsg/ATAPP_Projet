using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATAPP_XML
{
    public partial class frmCon : Form
    {
        static string username, folder, xmlFile, result;

        fileXML file;

        public frmCon()
        {
            InitializeComponent();

            //Récupère le nom d'utilisateur de Windows
            username = Environment.UserName;

            folder = @"C:\Users\%Users%\Documents\data\".Replace("%Users%", username);
            xmlFile = "database.xml";

            file = new fileXML(username, folder, xmlFile);

            //Renvoie si Oui/Non le dossier et le fichier existe
            result = file.VerifyIfExist();
        }

        private void frmCon_Load(object sender, EventArgs e)
        {
            VerifyIfFirstOpen();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            string enteredPwd = tbxConPwd.Text;
            if (enteredPwd != string.Empty)
            {
                file.ActionOnFile(false, enteredPwd);
                CloseThis(enteredPwd);
            }
        }

        /// <summary>
        /// Méthode qui permet de fermer le formulaire de connexion et d'ouvrir le formulaire principal
        /// </summary>
        public void CloseThis(string p)
        {
            this.Hide();
            frmMain form = new frmMain(p);
            // déchiffrement du fichier
            form.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Méthode qui permet de vérifier si l'application est ouvert pour la première fois
        /// </summary>
        public void VerifyIfFirstOpen()
        {
            if (result != "OK")
            {
                this.Hide();
                frmCreate form = new frmCreate();
                form.ShowDialog();
                this.Close();
            }
        }
    }
}