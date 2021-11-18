namespace BigTycoon
{
    partial class GiocoPrincipale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerGuida = new System.Windows.Forms.Timer(this.components);
            this.guida = new System.Windows.Forms.PictureBox();
            this.dialogo = new System.Windows.Forms.Label();
            this.timerDialogo = new System.Windows.Forms.Timer(this.components);
            this.timerGuida2 = new System.Windows.Forms.Timer(this.components);
            this.casaPlayer = new System.Windows.Forms.PictureBox();
            this.ZonaNonEdificabile = new System.Windows.Forms.Panel();
            this.posizionamentoCasaSpostamento = new System.Windows.Forms.Timer(this.components);
            this.timerEdificio = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timerEdificio2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.quantitaOroLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.quantitaArgentoLabel = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.quantitaDenaroLabel = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.acquisto = new System.Windows.Forms.Timer(this.components);
            this.checkSaldo = new System.Windows.Forms.Timer(this.components);
            this.timerAffitti = new System.Windows.Forms.Timer(this.components);
            this.timerGuadagnosecondario = new System.Windows.Forms.Timer(this.components);
            this.nuotatore = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.prova = new System.Windows.Forms.Timer(this.components);
            this.listenerEliminaEdifici = new System.Windows.Forms.Timer(this.components);
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.arrivoTreno = new System.Windows.Forms.Timer(this.components);
            this.animazioneTreno = new System.Windows.Forms.Timer(this.components);
            this.animazioneTrenoIndietro = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timerAmbiente = new System.Windows.Forms.Timer(this.components);
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.produzioneIndustrieTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.guida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casaPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuotatore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // timerGuida
            // 
            this.timerGuida.Interval = 10;
            this.timerGuida.Tick += new System.EventHandler(this.timerGuida_Tick);
            // 
            // guida
            // 
            this.guida.BackColor = System.Drawing.Color.Transparent;
            this.guida.BackgroundImage = global::BigTycoon.Properties.Resources.guida1;
            this.guida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guida.Location = new System.Drawing.Point(333, 442);
            this.guida.Name = "guida";
            this.guida.Size = new System.Drawing.Size(419, 275);
            this.guida.TabIndex = 0;
            this.guida.TabStop = false;
            // 
            // dialogo
            // 
            this.dialogo.AutoSize = true;
            this.dialogo.BackColor = System.Drawing.Color.White;
            this.dialogo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dialogo.Location = new System.Drawing.Point(345, 435);
            this.dialogo.Name = "dialogo";
            this.dialogo.Size = new System.Drawing.Size(52, 17);
            this.dialogo.TabIndex = 1;
            this.dialogo.Text = "label1";
            this.dialogo.Visible = false;
            // 
            // timerDialogo
            // 
            this.timerDialogo.Interval = 1500;
            this.timerDialogo.Tick += new System.EventHandler(this.timerDialogo_Tick);
            // 
            // timerGuida2
            // 
            this.timerGuida2.Interval = 10;
            this.timerGuida2.Tick += new System.EventHandler(this.timerGuida2_Tick);
            // 
            // casaPlayer
            // 
            this.casaPlayer.BackColor = System.Drawing.Color.Transparent;
            this.casaPlayer.BackgroundImage = global::BigTycoon.Properties.Resources.casaPlayer;
            this.casaPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.casaPlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.casaPlayer.Location = new System.Drawing.Point(117, 66);
            this.casaPlayer.Name = "casaPlayer";
            this.casaPlayer.Size = new System.Drawing.Size(105, 91);
            this.casaPlayer.TabIndex = 2;
            this.casaPlayer.TabStop = false;
            this.casaPlayer.Visible = false;
            // 
            // ZonaNonEdificabile
            // 
            this.ZonaNonEdificabile.BackColor = System.Drawing.Color.Transparent;
            this.ZonaNonEdificabile.Location = new System.Drawing.Point(-5, -3);
            this.ZonaNonEdificabile.Name = "ZonaNonEdificabile";
            this.ZonaNonEdificabile.Size = new System.Drawing.Size(75, 114);
            this.ZonaNonEdificabile.TabIndex = 3;
            // 
            // posizionamentoCasaSpostamento
            // 
            this.posizionamentoCasaSpostamento.Enabled = true;
            this.posizionamentoCasaSpostamento.Interval = 10;
            this.posizionamentoCasaSpostamento.Tick += new System.EventHandler(this.posizionamentoCasaSpostamento_Tick);
            // 
            // timerEdificio
            // 
            this.timerEdificio.Interval = 1000;
            this.timerEdificio.Tick += new System.EventHandler(this.timerEdificio_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(102, -3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(120, 13);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Visible = false;
            // 
            // timerEdificio2
            // 
            this.timerEdificio2.Interval = 1000;
            this.timerEdificio2.Tick += new System.EventHandler(this.timerEdificio2_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::BigTycoon.Properties.Resources.Barra_oro;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(896, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 47);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // quantitaOroLabel
            // 
            this.quantitaOroLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.quantitaOroLabel.AutoSize = true;
            this.quantitaOroLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(100)))), ((int)(((byte)(50)))));
            this.quantitaOroLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantitaOroLabel.Location = new System.Drawing.Point(945, 26);
            this.quantitaOroLabel.Name = "quantitaOroLabel";
            this.quantitaOroLabel.Size = new System.Drawing.Size(49, 16);
            this.quantitaOroLabel.TabIndex = 6;
            this.quantitaOroLabel.Text = "label1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::BigTycoon.Properties.Resources.Barra_argento;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(896, 66);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(157, 47);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // quantitaArgentoLabel
            // 
            this.quantitaArgentoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.quantitaArgentoLabel.AutoSize = true;
            this.quantitaArgentoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(100)))), ((int)(((byte)(50)))));
            this.quantitaArgentoLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantitaArgentoLabel.Location = new System.Drawing.Point(945, 80);
            this.quantitaArgentoLabel.Name = "quantitaArgentoLabel";
            this.quantitaArgentoLabel.Size = new System.Drawing.Size(49, 16);
            this.quantitaArgentoLabel.TabIndex = 8;
            this.quantitaArgentoLabel.Text = "label1";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::BigTycoon.Properties.Resources.shop_button;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(24, 360);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(87, 81);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // quantitaDenaroLabel
            // 
            this.quantitaDenaroLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.quantitaDenaroLabel.AutoSize = true;
            this.quantitaDenaroLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(100)))), ((int)(((byte)(50)))));
            this.quantitaDenaroLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantitaDenaroLabel.Location = new System.Drawing.Point(945, 133);
            this.quantitaDenaroLabel.Name = "quantitaDenaroLabel";
            this.quantitaDenaroLabel.Size = new System.Drawing.Size(49, 16);
            this.quantitaDenaroLabel.TabIndex = 13;
            this.quantitaDenaroLabel.Text = "label1";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::BigTycoon.Properties.Resources.Barra_soldi;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(896, 119);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(157, 47);
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // acquisto
            // 
            this.acquisto.Enabled = true;
            this.acquisto.Tick += new System.EventHandler(this.acquisto_Tick);
            // 
            // checkSaldo
            // 
            this.checkSaldo.Enabled = true;
            this.checkSaldo.Tick += new System.EventHandler(this.checkSaldo_Tick);
            // 
            // timerAffitti
            // 
            this.timerAffitti.Enabled = true;
            this.timerAffitti.Interval = 10000;
            this.timerAffitti.Tick += new System.EventHandler(this.timerAffitti_Tick);
            // 
            // timerGuadagnosecondario
            // 
            this.timerGuadagnosecondario.Interval = 1000;
            this.timerGuadagnosecondario.Tick += new System.EventHandler(this.timerGuadagnosecondario_Tick);
            // 
            // nuotatore
            // 
            this.nuotatore.BackColor = System.Drawing.Color.Transparent;
            this.nuotatore.BackgroundImage = global::BigTycoon.Properties.Resources.nuotatore;
            this.nuotatore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nuotatore.Location = new System.Drawing.Point(652, 435);
            this.nuotatore.Name = "nuotatore";
            this.nuotatore.Size = new System.Drawing.Size(50, 40);
            this.nuotatore.TabIndex = 14;
            this.nuotatore.TabStop = false;
            this.nuotatore.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = global::BigTycoon.Properties.Resources.citta_button;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(133, 360);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(89, 82);
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // prova
            // 
            this.prova.Interval = 40000;
            this.prova.Tick += new System.EventHandler(this.prova_Tick);
            // 
            // listenerEliminaEdifici
            // 
            this.listenerEliminaEdifici.Enabled = true;
            this.listenerEliminaEdifici.Tick += new System.EventHandler(this.listenerEliminaEdifici_Tick);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImage = global::BigTycoon.Properties.Resources.salvaGioco_icona;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(836, 10);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(35, 32);
            this.pictureBox6.TabIndex = 16;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // arrivoTreno
            // 
            this.arrivoTreno.Interval = 30000;
            this.arrivoTreno.Tick += new System.EventHandler(this.arrivoTreno_Tick);
            // 
            // animazioneTreno
            // 
            this.animazioneTreno.Interval = 200;
            this.animazioneTreno.Tick += new System.EventHandler(this.animazioneTreno_Tick);
            // 
            // animazioneTrenoIndietro
            // 
            this.animazioneTrenoIndietro.Interval = 200;
            this.animazioneTrenoIndietro.Tick += new System.EventHandler(this.animazioneTrenoIndietro_Tick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.BackgroundImage = global::BigTycoon.Properties.Resources.materiali_button;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(782, 360);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(89, 82);
            this.pictureBox7.TabIndex = 19;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Visible = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.BackgroundImage = global::BigTycoon.Properties.Resources.barra_ambiente;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Location = new System.Drawing.Point(555, 9);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(157, 47);
            this.pictureBox8.TabIndex = 20;
            this.pictureBox8.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(614, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "0%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1051, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "label1";
            // 
            // timerAmbiente
            // 
            this.timerAmbiente.Enabled = true;
            this.timerAmbiente.Interval = 30000;
            this.timerAmbiente.Tick += new System.EventHandler(this.timerAmbiente_Tick);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.BackgroundImage = global::BigTycoon.Properties.Resources.topdown_button;
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox9.Location = new System.Drawing.Point(896, 360);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(89, 82);
            this.pictureBox9.TabIndex = 22;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Visible = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // produzioneIndustrieTimer
            // 
            this.produzioneIndustrieTimer.Enabled = true;
            this.produzioneIndustrieTimer.Tick += new System.EventHandler(this.produzioneIndustrieTimer_Tick);
            // 
            // GiocoPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BigTycoon.Properties.Resources.Background21;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1065, 450);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.nuotatore);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.quantitaDenaroLabel);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.quantitaArgentoLabel);
            this.Controls.Add(this.quantitaOroLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dialogo);
            this.Controls.Add(this.guida);
            this.Controls.Add(this.ZonaNonEdificabile);
            this.Controls.Add(this.casaPlayer);
            this.Name = "GiocoPrincipale";
            this.Text = "GiocoPrincipale";
            this.Load += new System.EventHandler(this.GiocoPrincipale_Load);
            this.Click += new System.EventHandler(this.GiocoPrincipale_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GiocoPrincipale_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GiocoPrincipale_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.guida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casaPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuotatore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox guida;
        private System.Windows.Forms.Timer timerGuida;
        private System.Windows.Forms.Label dialogo;
        private System.Windows.Forms.Timer timerDialogo;
        private System.Windows.Forms.Timer timerGuida2;
        private System.Windows.Forms.PictureBox casaPlayer;
        private System.Windows.Forms.Panel ZonaNonEdificabile;
        private System.Windows.Forms.Timer posizionamentoCasaSpostamento;
        private System.Windows.Forms.Timer timerEdificio;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timerEdificio2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label quantitaOroLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label quantitaArgentoLabel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label quantitaDenaroLabel;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Timer acquisto;
        private System.Windows.Forms.Timer checkSaldo;
        private System.Windows.Forms.Timer timerAffitti;
        private System.Windows.Forms.Timer timerGuadagnosecondario;
        private System.Windows.Forms.PictureBox nuotatore;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Timer prova;
        private System.Windows.Forms.Timer listenerEliminaEdifici;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Timer arrivoTreno;
        private System.Windows.Forms.Timer animazioneTreno;
        private System.Windows.Forms.Timer animazioneTrenoIndietro;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerAmbiente;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer produzioneIndustrieTimer;
    }
}