namespace EasyReqAssist.Forms
{
    partial class FrmNoviZahtjev
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNoviZahtjev));
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtZahtjev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtObrazlozenje = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNacinProvjere = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrioritet = new System.Windows.Forms.TextBox();
            this.txtIzvor = new System.Windows.Forms.TextBox();
            this.btnSpremiZahtjev = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.toolTipID = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipZahtjev = new System.Windows.Forms.ToolTip(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpDatumZahjteva = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.toolTipDatumZahtjeva = new System.Windows.Forms.ToolTip(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.toolTipVrstaZahtjeva = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipObrazloženje = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPrioritet = new System.Windows.Forms.ToolTip(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.toolTipIzvor = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipStatus = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipNacinProvjere = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identifikator:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipID.SetToolTip(this.label1, "Jedinstvena oznaka svakog pojedinačnog zahtjeva, nužna\r\n za jednoznačno identific" +
        "iranje. Npr. FZ-1, Z-01, NFZ-1... ");
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(322, 27);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(313, 20);
            this.txtID.TabIndex = 1;
            // 
            // txtZahtjev
            // 
            this.txtZahtjev.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtZahtjev.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZahtjev.Location = new System.Drawing.Point(322, 53);
            this.txtZahtjev.Multiline = true;
            this.txtZahtjev.Name = "txtZahtjev";
            this.txtZahtjev.Size = new System.Drawing.Size(313, 50);
            this.txtZahtjev.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 56);
            this.label2.TabIndex = 2;
            this.label2.Text = "Zahtjev:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipZahtjev.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // txtObrazlozenje
            // 
            this.txtObrazlozenje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObrazlozenje.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObrazlozenje.Location = new System.Drawing.Point(322, 161);
            this.txtObrazlozenje.Multiline = true;
            this.txtObrazlozenje.Name = "txtObrazlozenje";
            this.txtObrazlozenje.Size = new System.Drawing.Size(313, 82);
            this.txtObrazlozenje.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(319, 88);
            this.label3.TabIndex = 4;
            this.label3.Text = "Obrazloženje:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipObrazloženje.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            // 
            // txtNacinProvjere
            // 
            this.txtNacinProvjere.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNacinProvjere.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNacinProvjere.Location = new System.Drawing.Point(322, 341);
            this.txtNacinProvjere.Multiline = true;
            this.txtNacinProvjere.Name = "txtNacinProvjere";
            this.txtNacinProvjere.Size = new System.Drawing.Size(313, 82);
            this.txtNacinProvjere.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 338);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(319, 88);
            this.label4.TabIndex = 6;
            this.label4.Text = "Način provjere:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipNacinProvjere.SetToolTip(this.label4, resources.GetString("label4.ToolTip"));
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(-8, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(783, 49);
            this.label5.TabIndex = 8;
            this.label5.Text = "Zahtjev #";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtNacinProvjere, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.txtID, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtPrioritet, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtObrazlozenje, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.dtpDatumZahjteva, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtZahtjev, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtIzvor, 1, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(74, 88);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(638, 426);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 246);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(319, 26);
            this.label6.TabIndex = 12;
            this.label6.Text = "Piroritet:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipPrioritet.SetToolTip(this.label6, "Pokazatelj hitnosti i/ili važnosti navedenog zahtjeva.\r\nPrioritet može poprimiti " +
        "brojčane vrijednosti (npr. 1-5)\r\nili tekstualne vrijednosti (npr. neizostavno, o" +
        "bavezno\r\nneobavezno, poželjno).");
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 272);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(319, 40);
            this.label7.TabIndex = 9;
            this.label7.Text = "Izvor:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipIzvor.SetToolTip(this.label7, "Naziv dionika koji je podnio zahtjev ili dokumenta\r\nkojim je zahtjev propisan.\r\nN" +
        "pr. \"Nastavnici na kolegiju Razvoj programskih\r\nproizvoda/Programsko inženjerstv" +
        "o.\"\r\n");
            // 
            // txtPrioritet
            // 
            this.txtPrioritet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrioritet.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrioritet.Location = new System.Drawing.Point(322, 249);
            this.txtPrioritet.Name = "txtPrioritet";
            this.txtPrioritet.Size = new System.Drawing.Size(313, 20);
            this.txtPrioritet.TabIndex = 10;
            // 
            // txtIzvor
            // 
            this.txtIzvor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIzvor.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIzvor.Location = new System.Drawing.Point(322, 275);
            this.txtIzvor.Multiline = true;
            this.txtIzvor.Name = "txtIzvor";
            this.txtIzvor.Size = new System.Drawing.Size(313, 34);
            this.txtIzvor.TabIndex = 13;
            // 
            // btnSpremiZahtjev
            // 
            this.btnSpremiZahtjev.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpremiZahtjev.Location = new System.Drawing.Point(506, 520);
            this.btnSpremiZahtjev.Name = "btnSpremiZahtjev";
            this.btnSpremiZahtjev.Size = new System.Drawing.Size(100, 55);
            this.btnSpremiZahtjev.TabIndex = 10;
            this.btnSpremiZahtjev.Text = "Spremi zahtjev";
            this.btnSpremiZahtjev.UseVisualStyleBackColor = true;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdustani.Location = new System.Drawing.Point(612, 520);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(100, 55);
            this.btnOdustani.TabIndex = 11;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // toolTipID
            // 
            this.toolTipID.IsBalloon = true;
            // 
            // toolTipZahtjev
            // 
            this.toolTipZahtjev.IsBalloon = true;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(319, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Atribut";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(319, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(319, 24);
            this.label9.TabIndex = 15;
            this.label9.Text = "Oznaka";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipZahtjev.SetToolTip(this.label9, "Test tooltip");
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(0, 106);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(319, 26);
            this.label10.TabIndex = 14;
            this.label10.Text = "Datum zahtjeva:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipDatumZahtjeva.SetToolTip(this.label10, "Datum kojeg ste kreirali zahtjev.");
            // 
            // dtpDatumZahjteva
            // 
            this.dtpDatumZahjteva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtpDatumZahjteva.Location = new System.Drawing.Point(378, 109);
            this.dtpDatumZahjteva.Name = "dtpDatumZahjteva";
            this.dtpDatumZahjteva.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumZahjteva.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(0, 132);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(319, 26);
            this.label11.TabIndex = 17;
            this.label11.Text = "Vrsta zahtjeva:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipVrstaZahtjeva.SetToolTip(this.label11, "Neka od vrsta zahtjeva s obzirom na klasifikaciju koju autori koriste. \r\nNpr. fun" +
        "kcionalni, nefunkcionalni...");
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(322, 135);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(313, 20);
            this.textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(322, 315);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(313, 20);
            this.textBox2.TabIndex = 19;
            // 
            // toolTipDatumZahtjeva
            // 
            this.toolTipDatumZahtjeva.IsBalloon = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 562);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(311, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "*Prijeđite mišem preko atributa kako biste saznali više informacija";
            // 
            // toolTipVrstaZahtjeva
            // 
            this.toolTipVrstaZahtjeva.IsBalloon = true;
            // 
            // toolTipObrazloženje
            // 
            this.toolTipObrazloženje.IsBalloon = true;
            // 
            // toolTipPrioritet
            // 
            this.toolTipPrioritet.IsBalloon = true;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(0, 312);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(319, 26);
            this.label12.TabIndex = 20;
            this.label12.Text = "Status:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipStatus.SetToolTip(this.label12, "Status u kojem se zahtjev nalazi.\r\nNpr. predložen, odbijen, prihvaćen, ispunjen.." +
        ".");
            // 
            // toolTipIzvor
            // 
            this.toolTipIzvor.IsBalloon = true;
            // 
            // toolTipStatus
            // 
            this.toolTipStatus.IsBalloon = true;
            // 
            // toolTipNacinProvjere
            // 
            this.toolTipNacinProvjere.IsBalloon = true;
            // 
            // FrmNoviZahtjev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 587);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremiZahtjev);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label5);
            this.Name = "FrmNoviZahtjev";
            this.Text = "Novi Zahtjev";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtZahtjev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtObrazlozenje;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNacinProvjere;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrioritet;
        private System.Windows.Forms.TextBox txtIzvor;
        private System.Windows.Forms.Button btnSpremiZahtjev;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.ToolTip toolTipID;
        private System.Windows.Forms.ToolTip toolTipZahtjev;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDatumZahjteva;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolTip toolTipDatumZahtjeva;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolTip toolTipVrstaZahtjeva;
        private System.Windows.Forms.ToolTip toolTipObrazloženje;
        private System.Windows.Forms.ToolTip toolTipPrioritet;
        private System.Windows.Forms.ToolTip toolTipIzvor;
        private System.Windows.Forms.ToolTip toolTipStatus;
        private System.Windows.Forms.ToolTip toolTipNacinProvjere;
    }
}