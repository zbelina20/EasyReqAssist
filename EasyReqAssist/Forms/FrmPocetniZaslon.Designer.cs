namespace EasyReqAssist
{
    partial class FrmPocetniZaslon
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnNoviZahtjev = new System.Windows.Forms.Button();
            this.dgvZahtjevi = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnObrisiZahtjev = new System.Windows.Forms.Button();
            this.btnDetaljiZahtjeva = new System.Windows.Forms.Button();
            this.btnSpremiUDatoteku = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZahtjevi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(-9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1188, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dobrodošli u EasyReqAssist - Vaša platforma za zahtjeve!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnNoviZahtjev
            // 
            this.btnNoviZahtjev.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNoviZahtjev.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoviZahtjev.Location = new System.Drawing.Point(37, 120);
            this.btnNoviZahtjev.Name = "btnNoviZahtjev";
            this.btnNoviZahtjev.Size = new System.Drawing.Size(125, 75);
            this.btnNoviZahtjev.TabIndex = 1;
            this.btnNoviZahtjev.Text = "Novi zahtjev";
            this.btnNoviZahtjev.UseVisualStyleBackColor = false;
            this.btnNoviZahtjev.Click += new System.EventHandler(this.btnNoviZahtjev_Click);
            // 
            // dgvZahtjevi
            // 
            this.dgvZahtjevi.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvZahtjevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZahtjevi.Location = new System.Drawing.Point(187, 120);
            this.dgvZahtjevi.Name = "dgvZahtjevi";
            this.dgvZahtjevi.Size = new System.Drawing.Size(942, 478);
            this.dgvZahtjevi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Popis zahtjeva:";
            // 
            // btnObrisiZahtjev
            // 
            this.btnObrisiZahtjev.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnObrisiZahtjev.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiZahtjev.Location = new System.Drawing.Point(37, 283);
            this.btnObrisiZahtjev.Name = "btnObrisiZahtjev";
            this.btnObrisiZahtjev.Size = new System.Drawing.Size(125, 75);
            this.btnObrisiZahtjev.TabIndex = 4;
            this.btnObrisiZahtjev.Text = "Obriši zahtjev";
            this.btnObrisiZahtjev.UseVisualStyleBackColor = false;
            // 
            // btnDetaljiZahtjeva
            // 
            this.btnDetaljiZahtjeva.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDetaljiZahtjeva.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetaljiZahtjeva.Location = new System.Drawing.Point(37, 201);
            this.btnDetaljiZahtjeva.Name = "btnDetaljiZahtjeva";
            this.btnDetaljiZahtjeva.Size = new System.Drawing.Size(125, 75);
            this.btnDetaljiZahtjeva.TabIndex = 5;
            this.btnDetaljiZahtjeva.Text = "Detalji zahtjeva";
            this.btnDetaljiZahtjeva.UseVisualStyleBackColor = false;
            this.btnDetaljiZahtjeva.Click += new System.EventHandler(this.btnDetaljiZahtjeva_Click);
            // 
            // btnSpremiUDatoteku
            // 
            this.btnSpremiUDatoteku.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSpremiUDatoteku.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpremiUDatoteku.Location = new System.Drawing.Point(37, 364);
            this.btnSpremiUDatoteku.Name = "btnSpremiUDatoteku";
            this.btnSpremiUDatoteku.Size = new System.Drawing.Size(125, 75);
            this.btnSpremiUDatoteku.TabIndex = 6;
            this.btnSpremiUDatoteku.Text = "Spremi u datoteku";
            this.btnSpremiUDatoteku.UseVisualStyleBackColor = false;
            this.btnSpremiUDatoteku.Click += new System.EventHandler(this.btnSpremiUDatoteku_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(-9, 628);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1188, 49);
            this.label3.TabIndex = 7;
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmPocetniZaslon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1173, 688);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSpremiUDatoteku);
            this.Controls.Add(this.btnDetaljiZahtjeva);
            this.Controls.Add(this.btnObrisiZahtjev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvZahtjevi);
            this.Controls.Add(this.btnNoviZahtjev);
            this.Controls.Add(this.label1);
            this.Name = "FrmPocetniZaslon";
            this.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyReqAssist";
            ((System.ComponentModel.ISupportInitialize)(this.dgvZahtjevi)).EndInit();
            this.ResumeLayout(false);

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
    }
}

