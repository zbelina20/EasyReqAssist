namespace EasyReqAssist.Forms
{
    partial class FrmNoviProjekt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNoviProjekt));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProjekt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKreirajProjekt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(-3, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(675, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "EasyReqAssist";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(-3, 259);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(675, 36);
            this.label2.TabIndex = 2;
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtProjekt
            // 
            this.txtProjekt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProjekt.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProjekt.Location = new System.Drawing.Point(123, 134);
            this.txtProjekt.Name = "txtProjekt";
            this.txtProjekt.Size = new System.Drawing.Size(409, 28);
            this.txtProjekt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(224, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "Naziv vašeg projekta:";
            // 
            // btnKreirajProjekt
            // 
            this.btnKreirajProjekt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKreirajProjekt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKreirajProjekt.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKreirajProjekt.Location = new System.Drawing.Point(240, 178);
            this.btnKreirajProjekt.Name = "btnKreirajProjekt";
            this.btnKreirajProjekt.Size = new System.Drawing.Size(88, 53);
            this.btnKreirajProjekt.TabIndex = 5;
            this.btnKreirajProjekt.Text = "Kreiraj projekt";
            this.btnKreirajProjekt.UseVisualStyleBackColor = false;
            this.btnKreirajProjekt.Click += new System.EventHandler(this.btnKreiranjeZahtjeva_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(55, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 72);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOdustani.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOdustani.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdustani.Location = new System.Drawing.Point(334, 178);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(88, 53);
            this.btnOdustani.TabIndex = 13;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // FrmNoviProjekt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 313);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnKreirajProjekt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProjekt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FrmNoviProjekt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyReqAssist";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProjekt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKreirajProjekt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOdustani;
    }
}