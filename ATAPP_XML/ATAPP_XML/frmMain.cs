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
    public partial class frmMain : Form
    {
        static string username, folder, xmlFile, key;

        fileXML file;

        public frmMain(string s)
        {
            key = s;

            InitializeComponent();

            //Récupère le nom d'utilisateur de Windows
            username = Environment.UserName;

            folder = @"C:\Users\%Users%\Documents\data\".Replace("%Users%", username);
            xmlFile = "database.xml";

            file = new fileXML(username, folder, xmlFile);
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            file.ActionOnFile(true, key);
        }
    }
}