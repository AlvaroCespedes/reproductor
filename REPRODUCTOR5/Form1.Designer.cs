namespace REPRODUCTOR5
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Reproductor = new AxWMPLib.AxWindowsMediaPlayer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Adjuntar = new System.Windows.Forms.Button();
            this.listGuardadas = new System.Windows.Forms.ListBox();
            this.Boton2 = new System.Windows.Forms.Button();
            this.btnAgregarInfo = new System.Windows.Forms.Button();
            this.panelCancion = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtPublicationYear = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.txtComposer = new System.Windows.Forms.TextBox();
            this.txtSinger = new System.Windows.Forms.TextBox();
            this.txtStudy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.mTrackStatus = new XComponent.SliderBar.MACTrackBar();
            this.mTrackVolumen = new XComponent.SliderBar.MACTrackBar();
            this.lblCancion = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStop = new System.Windows.Forms.PictureBox();
            this.btnPlay2 = new System.Windows.Forms.PictureBox();
            this.listBoxAgregar = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnContinuar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).BeginInit();
            this.panelCancion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Reproductor
            // 
            this.Reproductor.Enabled = true;
            this.Reproductor.Location = new System.Drawing.Point(41, 12);
            this.Reproductor.Name = "Reproductor";
            this.Reproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Reproductor.OcxState")));
            this.Reproductor.Size = new System.Drawing.Size(66, 30);
            this.Reproductor.TabIndex = 0;
            this.Reproductor.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.Reproductor_PlayStateChange);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(41, 177);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(263, 84);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Adjuntar
            // 
            this.Adjuntar.Location = new System.Drawing.Point(310, 177);
            this.Adjuntar.Name = "Adjuntar";
            this.Adjuntar.Size = new System.Drawing.Size(139, 38);
            this.Adjuntar.TabIndex = 2;
            this.Adjuntar.Text = "Subir cancion";
            this.Adjuntar.UseVisualStyleBackColor = true;
            this.Adjuntar.Click += new System.EventHandler(this.Adjuntar_Click);
            // 
            // listGuardadas
            // 
            this.listGuardadas.FormattingEnabled = true;
            this.listGuardadas.ItemHeight = 16;
            this.listGuardadas.Location = new System.Drawing.Point(496, 12);
            this.listGuardadas.Name = "listGuardadas";
            this.listGuardadas.Size = new System.Drawing.Size(171, 276);
            this.listGuardadas.TabIndex = 3;
            this.listGuardadas.SelectedIndexChanged += new System.EventHandler(this.listGuardadas_SelectedIndexChanged);
            // 
            // Boton2
            // 
            this.Boton2.Location = new System.Drawing.Point(187, 276);
            this.Boton2.Name = "Boton2";
            this.Boton2.Size = new System.Drawing.Size(139, 40);
            this.Boton2.TabIndex = 4;
            this.Boton2.Text = "Deserializar";
            this.Boton2.UseVisualStyleBackColor = true;
            this.Boton2.Click += new System.EventHandler(this.Boton2_Click);
            // 
            // btnAgregarInfo
            // 
            this.btnAgregarInfo.Location = new System.Drawing.Point(41, 272);
            this.btnAgregarInfo.Name = "btnAgregarInfo";
            this.btnAgregarInfo.Size = new System.Drawing.Size(139, 47);
            this.btnAgregarInfo.TabIndex = 5;
            this.btnAgregarInfo.Text = "Agregar Info";
            this.btnAgregarInfo.UseVisualStyleBackColor = true;
            this.btnAgregarInfo.Click += new System.EventHandler(this.btnAgregarInfo_Click);
            // 
            // panelCancion
            // 
            this.panelCancion.Controls.Add(this.button1);
            this.panelCancion.Controls.Add(this.label8);
            this.panelCancion.Controls.Add(this.lblCancion);
            this.panelCancion.Controls.Add(this.label7);
            this.panelCancion.Controls.Add(this.label6);
            this.panelCancion.Controls.Add(this.label5);
            this.panelCancion.Controls.Add(this.label4);
            this.panelCancion.Controls.Add(this.label3);
            this.panelCancion.Controls.Add(this.label2);
            this.panelCancion.Controls.Add(this.label1);
            this.panelCancion.Controls.Add(this.txtStudy);
            this.panelCancion.Controls.Add(this.txtSinger);
            this.panelCancion.Controls.Add(this.txtComposer);
            this.panelCancion.Controls.Add(this.txtAlbum);
            this.panelCancion.Controls.Add(this.txtKeyword);
            this.panelCancion.Controls.Add(this.txtGender);
            this.panelCancion.Controls.Add(this.txtPublicationYear);
            this.panelCancion.Controls.Add(this.txtTitle);
            this.panelCancion.Controls.Add(this.btnVolver);
            this.panelCancion.Location = new System.Drawing.Point(0, 3);
            this.panelCancion.Name = "panelCancion";
            this.panelCancion.Size = new System.Drawing.Size(800, 450);
            this.panelCancion.TabIndex = 6;
            this.panelCancion.Visible = false;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(308, 367);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(133, 63);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(148, 77);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(169, 22);
            this.txtTitle.TabIndex = 1;
            // 
            // txtPublicationYear
            // 
            this.txtPublicationYear.Location = new System.Drawing.Point(588, 107);
            this.txtPublicationYear.Name = "txtPublicationYear";
            this.txtPublicationYear.Size = new System.Drawing.Size(169, 22);
            this.txtPublicationYear.TabIndex = 3;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(148, 189);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(169, 22);
            this.txtGender.TabIndex = 4;
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(588, 77);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(169, 22);
            this.txtKeyword.TabIndex = 5;
            // 
            // txtAlbum
            // 
            this.txtAlbum.Location = new System.Drawing.Point(148, 161);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size(169, 22);
            this.txtAlbum.TabIndex = 6;
            // 
            // txtComposer
            // 
            this.txtComposer.Location = new System.Drawing.Point(148, 133);
            this.txtComposer.Name = "txtComposer";
            this.txtComposer.Size = new System.Drawing.Size(169, 22);
            this.txtComposer.TabIndex = 7;
            // 
            // txtSinger
            // 
            this.txtSinger.Location = new System.Drawing.Point(148, 105);
            this.txtSinger.Name = "txtSinger";
            this.txtSinger.Size = new System.Drawing.Size(169, 22);
            this.txtSinger.TabIndex = 8;
            // 
            // txtStudy
            // 
            this.txtStudy.Location = new System.Drawing.Point(148, 217);
            this.txtStudy.Name = "txtStudy";
            this.txtStudy.Size = new System.Drawing.Size(169, 22);
            this.txtStudy.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Titulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Cantante";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Compositor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Album";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Genero";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "estudio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(445, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "PalabraClave";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(445, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "AñoPublicacion";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 35);
            this.button1.TabIndex = 21;
            this.button1.Text = "Agregar Ahora";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mTrackStatus
            // 
            this.mTrackStatus.BackColor = System.Drawing.Color.Transparent;
            this.mTrackStatus.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.mTrackStatus.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTrackStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.mTrackStatus.IndentHeight = 6;
            this.mTrackStatus.Location = new System.Drawing.Point(41, 325);
            this.mTrackStatus.Maximum = 10;
            this.mTrackStatus.Minimum = 0;
            this.mTrackStatus.Name = "mTrackStatus";
            this.mTrackStatus.Size = new System.Drawing.Size(248, 51);
            this.mTrackStatus.TabIndex = 7;
            this.mTrackStatus.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.mTrackStatus.TickHeight = 4;
            this.mTrackStatus.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(130)))), ((int)(((byte)(198)))));
            this.mTrackStatus.TrackerSize = new System.Drawing.Size(16, 16);
            this.mTrackStatus.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.mTrackStatus.TrackLineHeight = 3;
            this.mTrackStatus.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.mTrackStatus.Value = 0;
            // 
            // mTrackVolumen
            // 
            this.mTrackVolumen.BackColor = System.Drawing.Color.Transparent;
            this.mTrackVolumen.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.mTrackVolumen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTrackVolumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.mTrackVolumen.IndentHeight = 6;
            this.mTrackVolumen.Location = new System.Drawing.Point(41, 388);
            this.mTrackVolumen.Maximum = 100;
            this.mTrackVolumen.Minimum = 0;
            this.mTrackVolumen.Name = "mTrackVolumen";
            this.mTrackVolumen.Size = new System.Drawing.Size(248, 28);
            this.mTrackVolumen.TabIndex = 8;
            this.mTrackVolumen.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.mTrackVolumen.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.mTrackVolumen.TickHeight = 4;
            this.mTrackVolumen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.mTrackVolumen.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(130)))), ((int)(((byte)(198)))));
            this.mTrackVolumen.TrackerSize = new System.Drawing.Size(16, 16);
            this.mTrackVolumen.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.mTrackVolumen.TrackLineHeight = 3;
            this.mTrackVolumen.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.mTrackVolumen.Value = 0;
            this.mTrackVolumen.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.mTrackVolumen_ValueChanged);
            // 
            // lblCancion
            // 
            this.lblCancion.AutoSize = true;
            this.lblCancion.Location = new System.Drawing.Point(555, 322);
            this.lblCancion.Name = "lblCancion";
            this.lblCancion.Size = new System.Drawing.Size(18, 17);
            this.lblCancion.TabIndex = 11;
            this.lblCancion.Text = "--";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStop
            // 
            this.btnStop.Image = global::REPRODUCTOR5.Properties.Resources.detener;
            this.btnStop.Location = new System.Drawing.Point(41, 56);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(112, 101);
            this.btnStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnStop.TabIndex = 13;
            this.btnStop.TabStop = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay2
            // 
            this.btnPlay2.Image = global::REPRODUCTOR5.Properties.Resources.play;
            this.btnPlay2.Location = new System.Drawing.Point(187, 56);
            this.btnPlay2.Name = "btnPlay2";
            this.btnPlay2.Size = new System.Drawing.Size(102, 95);
            this.btnPlay2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPlay2.TabIndex = 14;
            this.btnPlay2.TabStop = false;
            this.btnPlay2.Click += new System.EventHandler(this.btnPlay2_Click);
            // 
            // listBoxAgregar
            // 
            this.listBoxAgregar.FormattingEnabled = true;
            this.listBoxAgregar.ItemHeight = 16;
            this.listBoxAgregar.Location = new System.Drawing.Point(348, 79);
            this.listBoxAgregar.Name = "listBoxAgregar";
            this.listBoxAgregar.Size = new System.Drawing.Size(167, 260);
            this.listBoxAgregar.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnContinuar);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.panelCancion);
            this.panel1.Controls.Add(this.listBoxAgregar);
            this.panel1.Location = new System.Drawing.Point(2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 457);
            this.panel1.TabIndex = 23;
            this.panel1.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(314, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(249, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Debe elegir una cancion para agregar";
            // 
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(336, 356);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(179, 32);
            this.btnContinuar.TabIndex = 24;
            this.btnContinuar.Text = "continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPlay2);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.mTrackVolumen);
            this.Controls.Add(this.mTrackStatus);
            this.Controls.Add(this.btnAgregarInfo);
            this.Controls.Add(this.Boton2);
            this.Controls.Add(this.listGuardadas);
            this.Controls.Add(this.Adjuntar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Reproductor);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).EndInit();
            this.panelCancion.ResumeLayout(false);
            this.panelCancion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer Reproductor;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Adjuntar;
        private System.Windows.Forms.ListBox listGuardadas;
        private System.Windows.Forms.Button Boton2;
        private System.Windows.Forms.Button btnAgregarInfo;
        private System.Windows.Forms.Panel panelCancion;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtSinger;
        private System.Windows.Forms.TextBox txtComposer;
        private System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtPublicationYear;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStudy;
        private System.Windows.Forms.Button button1;
        private XComponent.SliderBar.MACTrackBar mTrackStatus;
        private XComponent.SliderBar.MACTrackBar mTrackVolumen;
        private System.Windows.Forms.Label lblCancion;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox btnStop;
        private System.Windows.Forms.PictureBox btnPlay2;
        private System.Windows.Forms.ListBox listBoxAgregar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnContinuar;
    }
}

