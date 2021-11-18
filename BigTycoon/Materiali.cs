using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigTycoon
{
    public partial class Materiali : Form
    {
        Giocatore g;
        PictureBox[] immagini_edifici = new PictureBox[8];
        Label[] labels = new Label[8];
        String[] labelMateriali = new String[8];
        String[] quantitaMateriale = new String[8];
        Label[] quantita = new Label[8];
        public Materiali(Giocatore g)
        {
            InitializeComponent();
            this.g = g;
            labelMateriali[0] = "legno";
            labelMateriali[1] = "ferro";
            labelMateriali[2] = "plastica";
            labelMateriali[3] = "alluminio";
            labelMateriali[4] = "rame";
            labelMateriali[5] = "oro";
            labelMateriali[6] = "diamanti";
            labelMateriali[7] = "argento";
            
            quantitaMateriale[0] = g.getLegno().ToString();
            quantitaMateriale[1] = g.getFerro().ToString();
            quantitaMateriale[2] = g.getPlastica().ToString();
            quantitaMateriale[3] = g.getAlluminio().ToString();
            quantitaMateriale[4] = g.getRame().ToString();
            quantitaMateriale[5] = g.getOro().ToString();
            quantitaMateriale[6] = g.getDiamanti().ToString();
            quantitaMateriale[7] = g.getArgento().ToString();
        }

        private void Materiali_Load(object sender, EventArgs e)
        {
            int assey = 85;
            Font labelFont = new Font("Arial", 8, FontStyle.Bold);
            for (int i = 0; i < 8; i++)
            {
                labels[i] = new Label();
                labels[i].Text = labelMateriali[i];
                labels[i].ForeColor = Color.White;
                labels[i].BackColor = Color.Transparent;
                labels[i].Font = labelFont;
                labels[i].Tag = i;

                quantita[i] = new Label();
                quantita[i].Text = quantitaMateriale[i];
                quantita[i].ForeColor = Color.White;
                quantita[i].BackColor = Color.Transparent;
                quantita[i].Font = labelFont;
                quantita[i].Tag = i;

                immagini_edifici[i] = new PictureBox();
                immagini_edifici[i].BackgroundImage = (Bitmap)BigTycoon.Properties.Resources.ResourceManager.GetObject(labelMateriali[i]);
                immagini_edifici[i].Location = new Point(10, assey);
                immagini_edifici[i].BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                immagini_edifici[i].BackColor = Color.Transparent;
                immagini_edifici[i].Size = new Size(40, 40);
                labels[i].Location = new Point(100, assey);
                quantita[i].Location =  new Point(200, assey);
                this.Controls.Add(labels[i]);
                this.Controls.Add(quantita[i]);
                this.Controls.Add(immagini_edifici[i]);

                assey += 40;
            }
        }
    }
}
