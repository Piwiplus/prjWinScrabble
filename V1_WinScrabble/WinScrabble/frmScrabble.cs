using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinScrabble
{
    public partial class frmScrabble : Form
    {
        // attributs de la classe frmScrabble (variables globales)
        // utiles pour les évolutions EVO01 et EVO02
        int totalPoints = 0;                // nombre de points du joueur
        int nbMots = 0;                     // nombre de mots proposés par le joueur
        string[] lesMots = new string[10];  // mots proposés par le joueur
        string meilMot = "";
        int meilPoint = 0;

        public frmScrabble()
        {
            InitializeComponent();
        }

        private void btnOkClick(object sender, EventArgs e)
        {
            if (nbMots<10)
            {
               
                string leMot = txtMot.Text;
                int nbPoints = Utilitaire.PointsMot(leMot);
                totalPoints = nbPoints + totalPoints;
                txtPoints.Text = nbPoints.ToString();
                totPoints.Text = totalPoints.ToString();
                btnOK.Enabled = false;
                lesMots[nbMots] = leMot;
                nbMots++;
                if (nbPoints > meilPoint)
                {
                    meilMot = leMot;
                }

                resClickk.Text = "vous avez saisie : " + nbMots + " Mot(s)";
                if (nbMots == 10)
                {
                    foreach (string Mot in lesMots)
                    {
                        txtBoxMots.AppendText(Mot +"\n");
                    }
                }
               
            }
        }

        private void btnAutreClick(object sender, EventArgs e)
        {
            txtMot.Clear();
            txtPoints.Clear();
            txtMot.Focus();
            btnOK.Enabled = true;
        }

        private void totPointsTextChanged(object sender, EventArgs e)
        {

        }

        private void txtPoints_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listMot_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void resClick(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
