namespace BigTycoon
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.noSalvataggi = new System.Windows.Forms.Label();
            this.villaggioSalvato = new System.Windows.Forms.PictureBox();
            this.carica = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.villaggioSalvato)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(1211, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 81);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 57);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(204, 440);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(298, 140);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.gioca);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(189, 599);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(322, 129);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(801, 625);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(161, 76);
            this.button4.TabIndex = 4;
            this.button4.Text = "Salvataggi";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // noSalvataggi
            // 
            this.noSalvataggi.AutoSize = true;
            this.noSalvataggi.BackColor = System.Drawing.Color.Transparent;
            this.noSalvataggi.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noSalvataggi.Location = new System.Drawing.Point(796, 388);
            this.noSalvataggi.Name = "noSalvataggi";
            this.noSalvataggi.Size = new System.Drawing.Size(225, 28);
            this.noSalvataggi.TabIndex = 5;
            this.noSalvataggi.Text = "Non hai salvataggi";
            this.noSalvataggi.Visible = false;
            // 
            // villaggioSalvato
            // 
            this.villaggioSalvato.BackColor = System.Drawing.Color.Transparent;
            this.villaggioSalvato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.villaggioSalvato.Location = new System.Drawing.Point(801, 440);
            this.villaggioSalvato.Name = "villaggioSalvato";
            this.villaggioSalvato.Size = new System.Drawing.Size(371, 164);
            this.villaggioSalvato.TabIndex = 6;
            this.villaggioSalvato.TabStop = false;
            this.villaggioSalvato.Visible = false;
            // 
            // carica
            // 
            this.carica.Location = new System.Drawing.Point(1193, 581);
            this.carica.Name = "carica";
            this.carica.Size = new System.Drawing.Size(75, 23);
            this.carica.TabIndex = 7;
            this.carica.Text = "carica";
            this.carica.UseVisualStyleBackColor = true;
            this.carica.Visible = false;
            this.carica.Click += new System.EventHandler(this.carica_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(1189, 457);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(108, 23);
            this.usernameLabel.TabIndex = 8;
            this.usernameLabel.Text = "username";
            this.usernameLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BigTycoon.Properties.Resources.Schermata_iniziale_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1337, 756);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.carica);
            this.Controls.Add(this.villaggioSalvato);
            this.Controls.Add(this.noSalvataggi);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.villaggioSalvato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label noSalvataggi;
        private System.Windows.Forms.PictureBox villaggioSalvato;
        private System.Windows.Forms.Button carica;
        private System.Windows.Forms.Label usernameLabel;
    }
}

