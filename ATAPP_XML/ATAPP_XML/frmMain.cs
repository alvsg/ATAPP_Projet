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
        private string _key;

        FileXML file;
        Secure pwd;
        Safe safe;

        public string Key { get => _key; }

        public frmMain(string key)
        {
            InitializeComponent();

            this._key = key;
            file = new FileXML();
            pwd = new Secure();
            safe = new Safe(this);
            pwd.ActionOnFile(true, this._key, "writing");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            safe.UpdateOnLoad(flpButtonData);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            safe.AddValuesInData();
            safe.CreateButton(safe.NewRecord, flpButtonData);
        }

        private void flpButtonData_ControlAdded(object sender, ControlEventArgs e)
        {
            if (flpButtonData.Controls.Count >= 2)
            {
                pwd.addInFile(_key, safe);
            }
            
        }
    }
}