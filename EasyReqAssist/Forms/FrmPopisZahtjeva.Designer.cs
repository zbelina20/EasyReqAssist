namespace EasyReqAssist
{
    partial class FrmPopisZahtjeva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPopisZahtjeva));
            this.label1 = new System.Windows.Forms.Label();
            this.btnNoviZahtjev = new System.Windows.Forms.Button();
            this.dgvZahtjevi = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnObrisiZahtjev = new System.Windows.Forms.Button();
            this.btnDetaljiZahtjeva = new System.Windows.Forms.Button();
            this.btnSpremiUDatoteku = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbTXTFile = new System.Windows.Forms.RadioButton();
            this.groupBoxSpremanje = new System.Windows.Forms.GroupBox();
            this.rbPDFFile = new System.Windows.Forms.RadioButton();
            this.rbCSVFile = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbProjekti = new System.Windows.Forms.ComboBox();
            this.btnNoviProjekt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZahtjevi)).BeginInit();
            this.groupBoxSpremanje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(-9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1280, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dobrodošli u EasyReqAssist - Vaša platforma za zahtjeve!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnNoviZahtjev
            // 
            this.btnNoviZahtjev.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNoviZahtjev.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoviZahtjev.Location = new System.Drawing.Point(40, 197);
            this.btnNoviZahtjev.Name = "btnNoviZahtjev";
            this.btnNoviZahtjev.Size = new System.Drawing.Size(120, 70);
            this.btnNoviZahtjev.TabIndex = 1;
            this.btnNoviZahtjev.Text = "Novi zahtjev";
            this.btnNoviZahtjev.UseVisualStyleBackColor = false;
            this.btnNoviZahtjev.Click += new System.EventHandler(this.btnNoviZahtjev_Click);
            // 
            // dgvZahtjevi
            // 
            this.dgvZahtjevi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvZahtjevi.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvZahtjevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZahtjevi.Location = new System.Drawing.Point(187, 120);
            this.dgvZahtjevi.Name = "dgvZahtjevi";
            this.dgvZahtjevi.Size = new System.Drawing.Size(1040, 478);
            this.dgvZahtjevi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Popis zahtjeva za projekt";
            // 
            // btnObrisiZahtjev
            // 
            this.btnObrisiZahtjev.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnObrisiZahtjev.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiZahtjev.Location = new System.Drawing.Point(40, 349);
            this.btnObrisiZahtjev.Name = "btnObrisiZahtjev";
            this.btnObrisiZahtjev.Size = new System.Drawing.Size(120, 70);
            this.btnObrisiZahtjev.TabIndex = 4;
            this.btnObrisiZahtjev.Text = "Obriši zahtjev";
            this.btnObrisiZahtjev.UseVisualStyleBackColor = false;
            this.btnObrisiZahtjev.Click += new System.EventHandler(this.btnObrisiZahtjev_Click);
            // 
            // btnDetaljiZahtjeva
            // 
            this.btnDetaljiZahtjeva.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDetaljiZahtjeva.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetaljiZahtjeva.Location = new System.Drawing.Point(40, 273);
            this.btnDetaljiZahtjeva.Name = "btnDetaljiZahtjeva";
            this.btnDetaljiZahtjeva.Size = new System.Drawing.Size(120, 70);
            this.btnDetaljiZahtjeva.TabIndex = 5;
            this.btnDetaljiZahtjeva.Text = "Detalji zahtjeva";
            this.btnDetaljiZahtjeva.UseVisualStyleBackColor = false;
            this.btnDetaljiZahtjeva.Click += new System.EventHandler(this.btnDetaljiZahtjeva_Click);
            // 
            // btnSpremiUDatoteku
            // 
            this.btnSpremiUDatoteku.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSpremiUDatoteku.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpremiUDatoteku.Location = new System.Drawing.Point(6, 113);
            this.btnSpremiUDatoteku.Name = "btnSpremiUDatoteku";
            this.btnSpremiUDatoteku.Size = new System.Drawing.Size(113, 50);
            this.btnSpremiUDatoteku.TabIndex = 6;
            this.btnSpremiUDatoteku.Text = "Spremi u datoteku";
            this.btnSpremiUDatoteku.UseVisualStyleBackColor = false;
            this.btnSpremiUDatoteku.Click += new System.EventHandler(this.btnSpremiUDatoteku_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(-9, 641);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1280, 49);
            this.label3.TabIndex = 7;
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 616);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(450, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "*Napomena: zahtjevi će biti automatski sortirani prema rednom broju nakon svake o" +
    "peracije.";
            // 
            // rbTXTFile
            // 
            this.rbTXTFile.AutoSize = true;
            this.rbTXTFile.Location = new System.Drawing.Point(5, 26);
            this.rbTXTFile.Name = "rbTXTFile";
            this.rbTXTFile.Size = new System.Drawing.Size(98, 20);
            this.rbTXTFile.TabIndex = 9;
            this.rbTXTFile.TabStop = true;
            this.rbTXTFile.Text = "TXT datoteka";
            this.rbTXTFile.UseVisualStyleBackColor = true;
            // 
            // groupBoxSpremanje
            // 
            this.groupBoxSpremanje.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBoxSpremanje.Controls.Add(this.rbPDFFile);
            this.groupBoxSpremanje.Controls.Add(this.rbCSVFile);
            this.groupBoxSpremanje.Controls.Add(this.rbTXTFile);
            this.groupBoxSpremanje.Controls.Add(this.btnSpremiUDatoteku);
            this.groupBoxSpremanje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxSpremanje.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSpremanje.Location = new System.Drawing.Point(40, 425);
            this.groupBoxSpremanje.Name = "groupBoxSpremanje";
            this.groupBoxSpremanje.Size = new System.Drawing.Size(120, 173);
            this.groupBoxSpremanje.TabIndex = 10;
            this.groupBoxSpremanje.TabStop = false;
            this.groupBoxSpremanje.Text = "Spremanje";
            // 
            // rbPDFFile
            // 
            this.rbPDFFile.AutoSize = true;
            this.rbPDFFile.Location = new System.Drawing.Point(5, 78);
            this.rbPDFFile.Name = "rbPDFFile";
            this.rbPDFFile.Size = new System.Drawing.Size(100, 20);
            this.rbPDFFile.TabIndex = 11;
            this.rbPDFFile.TabStop = true;
            this.rbPDFFile.Text = "PDF datoteka";
            this.rbPDFFile.UseVisualStyleBackColor = true;
            // 
            // rbCSVFile
            // 
            this.rbCSVFile.AutoSize = true;
            this.rbCSVFile.Location = new System.Drawing.Point(5, 52);
            this.rbCSVFile.Name = "rbCSVFile";
            this.rbCSVFile.Size = new System.Drawing.Size(99, 20);
            this.rbCSVFile.TabIndex = 10;
            this.rbCSVFile.TabStop = true;
            this.rbCSVFile.Text = "CSV datoteka";
            this.rbCSVFile.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(55, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 72);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // cmbProjekti
            // 
            this.cmbProjekti.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProjekti.FormattingEnabled = true;
            this.cmbProjekti.Location = new System.Drawing.Point(447, 80);
            this.cmbProjekti.Name = "cmbProjekti";
            this.cmbProjekti.Size = new System.Drawing.Size(168, 32);
            this.cmbProjekti.TabIndex = 12;
            // 
            // btnNoviProjekt
            // 
            this.btnNoviProjekt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNoviProjekt.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoviProjekt.Location = new System.Drawing.Point(40, 120);
            this.btnNoviProjekt.Name = "btnNoviProjekt";
            this.btnNoviProjekt.Size = new System.Drawing.Size(120, 70);
            this.btnNoviProjekt.TabIndex = 13;
            this.btnNoviProjekt.Text = "Novi projekt";
            this.btnNoviProjekt.UseVisualStyleBackColor = false;
            this.btnNoviProjekt.Click += new System.EventHandler(this.btnNoviProjekt_Click);
            // 
            // FrmPopisZahtjeva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1266, 710);
            this.Controls.Add(this.btnNoviProjekt);
            this.Controls.Add(this.cmbProjekti);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxSpremanje);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDetaljiZahtjeva);
            this.Controls.Add(this.btnObrisiZahtjev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvZahtjevi);
            this.Controls.Add(this.btnNoviZahtjev);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPopisZahtjeva";
            this.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyReqAssist";
            ((System.ComponentModel.ISupportInitialize)(this.dgvZahtjevi)).EndInit();
            this.groupBoxSpremanje.ResumeLayout(false);
            this.groupBoxSpremanje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNoviZahtjev;
        private System.Windows.Forms.DataGridView dgvZahtjevi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnObrisiZahtjev;
        private System.Windows.Forms.Button btnDetaljiZahtjeva;
        private System.Windows.Forms.Button btnSpremiUDatoteku;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbTXTFile;
        private System.Windows.Forms.GroupBox groupBoxSpremanje;
        private System.Windows.Forms.RadioButton rbPDFFile;
        private System.Windows.Forms.RadioButton rbCSVFile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbProjekti;
        private System.Windows.Forms.Button btnNoviProjekt;
    }
}

