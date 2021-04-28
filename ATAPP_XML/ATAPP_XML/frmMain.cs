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

        Secure pwd;
        Safe safe;

        public string Key { get => _key; }

        /// <summary>
        /// Constructeur principal de la classe frmMain avec le mot de passe en paramètre
        /// </summary>
        /// <param name="key"> Le mot de passe de l'utilisateur </param>
        public frmMain(string key)
        {
            InitializeComponent();

            this._key = key;
            pwd = new Secure();
            safe = new Safe(this);
            pwd.ActionOnFile(true, this._key, "writing");
        }

        /// <summary>
        /// Méthode qui permet de mettre à jour l'affichage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            safe.UpdateOnLoad(flpButtonData);
        }

        /// <summary>
        /// Méthode qui permet d'ajouter les données dans le fichier XML lors de l'ajout d'un bouton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void flpButtonData_ControlAdded(object sender, ControlEventArgs e)
        {
            if (flpButtonData.Controls.Count > safe.NoDonnee)
            {
                pwd.addInFile(_key, safe);
                safe.NoDonnee++;
            }
        }

        /// <summary>
        /// Méthode qui permet d'ajouter une donnée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNouveau_Click(object sender, EventArgs e)
        {
            safe.AddValuesInData();
            if (!safe.Cancel)
            {
                safe.CreateButton(safe.NewRecord, flpButtonData);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}