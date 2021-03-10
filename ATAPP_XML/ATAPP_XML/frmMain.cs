/*
 * PROJET : Bilbio-tech
 * AUTEUR : ALVES GUASTTI Letitia (I.FA-P3A)
 * DESC. : Un gestionnaire de mot de passe
 * VERSION : 26.01.2021 v.1
 */

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
        static string key;
        fileXML file;

        public frmMain(string s)
        {
            key = s;

            InitializeComponent();
            file = new fileXML();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            file.ActionOnFile(true, key);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //string[] data = file.GetDataInArray();
            //file.ActionOnFile(true, key);
        }
    }
}