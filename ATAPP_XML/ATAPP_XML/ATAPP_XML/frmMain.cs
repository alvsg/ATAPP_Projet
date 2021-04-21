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
        Password pwd;
        Safe safe;

        public string Key { get => _key; }

        public frmMain(string key)
        {
            InitializeComponent();

            _key = key;
            file = new FileXML();
            pwd = new Password();
            safe = new Safe();
            pwd.ActionOnFile(true, _key, "writing");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            safe.UpdateViewOfSafe(flpButtonData);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            safe.AddValuesInData();
            safe.UpdateViewOfSafe(flpButtonData);
            addInFile();
        }

        public void addInFile()
        {
            pwd.ActionOnFile(false, _key, "writing");
            foreach (Record record in safe.Coffre)
            {
                int noIndex = safe.Coffre.FindIndex(a => a.Name == record.Name);
                if (safe.AddedInXmlFile.Contains(noIndex) == true)
                {
                    file.InsertDataInFile(record.Username, record.Name, record.Password, noIndex);
                }
                else if (safe.ModifiedInXmlFile.Contains(noIndex) == true)
                {
                    file.UpdateDataInXml(record.Username, record.Name, record.Password, noIndex);
                    if (_key != safe.Coffre[0].Password)
                    {
                        _key = safe.Coffre[0].Password;
                    }
                }
            }
            //pwd.ActionOnFile(true, _key, "");
        }
    }
}