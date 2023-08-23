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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnObrisiZahtjev = new System.Windows.Forms.Button();
            this.btnDetaljiZahtjeva = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(-9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(878, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dobrodošli u EasyReqAssist - Vaša platforma za zahtjeve!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnNoviZahtjev
            // 
            this.btnNoviZahtjev.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoviZahtjev.Location = new System.Drawing.Point(35, 159);
            this.btnNoviZahtjev.Name = "btnNoviZahtjev";
            this.btnNoviZahtjev.Size = new System.Drawing.Size(125, 75);
            this.btnNoviZahtjev.TabIndex = 1;
            this.btnNoviZahtjev.Text = "Novi Zahtjev";
            this.btnNoviZahtjev.UseVisualStyleBackColor = true;
            this.btnNoviZahtjev.Click += new System.EventHandler(this.btnNoviZahtjev_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(187, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(655, 319);
            this.dataGridView1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Popis zahtjeva:";
            // 
            // btnObrisiZahtjev
            // 
            this.btnObrisiZahtjev.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiZahtjev.Location = new System.Drawing.Point(35, 240);
            this.btnObrisiZahtjev.Name = "btnObrisiZahtjev";
            this.btnObrisiZahtjev.Size = new System.Drawing.Size(125, 75);
            this.btnObrisiZahtjev.TabIndex = 4;
            this.btnObrisiZahtjev.Text = "Obriši Zahtjev";
            this.btnObrisiZahtjev.UseVisualStyleBackColor = true;
            // 
            // btnDetaljiZahtjeva
            // 
            this.btnDetaljiZahtjeva.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetaljiZahtjeva.Location = new System.Drawing.Point(35, 321);
            this.btnDetaljiZahtjeva.Name = "btnDetaljiZahtjeva";
            this.btnDetaljiZahtjeva.Size = new System.Drawing.Size(125, 75);
            this.btnDetaljiZahtjeva.TabIndex = 5;
            this.btnDetaljiZahtjeva.Text = "Detalji Zahtjeva";
            this.btnDetaljiZahtjeva.UseVisualStyleBackColor = true;
            // 
            // FrmPocetniZaslon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 461);
            this.Controls.Add(this.btnDetaljiZahtjeva);
            this.Controls.Add(this.btnObrisiZahtjev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnNoviZahtjev);
            this.Controls.Add(this.label1);
            this.Name = "FrmPocetniZaslon";
            this.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "EasyReqAssist";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNoviZahtjev;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnObrisiZahtjev;
        private System.Windows.Forms.Button btnDetaljiZahtjeva;
    }
}

