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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelZahtjev = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNacinProvjere = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdentifikator = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrioritet = new System.Windows.Forms.TextBox();
            this.txtObrazlozenje = new System.Windows.Forms.TextBox();
            this.txtVrsta = new System.Windows.Forms.TextBox();
            this.dtpDatumZahjteva = new System.Windows.Forms.DateTimePicker();
            this.txtZahtjev = new System.Windows.Forms.TextBox();
            this.txtIzvor = new System.Windows.Forms.TextBox();
            this.btnProvjeriZahtjev = new System.Windows.Forms.Button();
            this.btnSpremiZahtjev = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.toolTipID = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipZahtjev = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipDatumZahtjeva = new System.Windows.Forms.ToolTip(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.toolTipVrstaZahtjeva = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipObrazloženje = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPrioritet = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipIzvor = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipStatus = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipNacinProvjere = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipGumbProvjeriZahtjev = new System.Windows.Forms.ToolTip(this.components);
            this.txtOdgovorAPIa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAlternative = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPovezaniZahtjevi = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identifikator:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipID.SetToolTip(this.label1, "Jedinstvena oznaka svakog pojedinačnog zahtjeva, nužna\r\n za jednoznačno identific" +
        "iranje. Npr. FZ-1, Z-01, NFZ-1... ");
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 56);
            this.label2.TabIndex = 2;
            this.label2.Text = "Zahtjev:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipZahtjev.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label3, 2);
            this.label3.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 88);
            this.label3.TabIndex = 4;
            this.label3.Text = "Obrazloženje:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipObrazloženje.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            // 
            // labelZahtjev
            // 
            this.labelZahtjev.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelZahtjev.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelZahtjev.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZahtjev.ForeColor = System.Drawing.Color.Black;
            this.labelZahtjev.Location = new System.Drawing.Point(-8, 9);
            this.labelZahtjev.Name = "labelZahtjev";
            this.labelZahtjev.Size = new System.Drawing.Size(1293, 49);
            this.labelZahtjev.TabIndex = 8;
            this.labelZahtjev.Text = "Zahtjev";
            this.labelZahtjev.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.24019F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.006279F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.75353F));
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.txtStatus, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtNacinProvjere, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.label9, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.txtIdentifikator, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtPrioritet, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtObrazlozenje, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtVrsta, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.dtpDatumZahjteva, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtZahtjev, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtIzvor, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnProvjeriZahtjev, 1, 2);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(638, 458);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label12, 2);
            this.label12.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1, 332);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(249, 29);
            this.label12.TabIndex = 20;
            this.label12.Text = "Status:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipStatus.SetToolTip(this.label12, "Status u kojem se zahtjev nalazi.\r\nNpr. predložen, odbijen, prihvaćen, ispunjen.." +
        ".\r\n");
            // 
            // txtStatus
            // 
            this.txtStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStatus.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(254, 335);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(380, 23);
            this.txtStatus.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label6, 2);
            this.label6.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1, 261);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Piroritet:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipPrioritet.SetToolTip(this.label6, "Pokazatelj hitnosti i/ili važnosti navedenog zahtjeva.\r\nPrioritet može poprimiti " +
        "brojčane vrijednosti (npr. 1-5)\r\nili tekstualne vrijednosti (npr. neizostavno, o" +
        "bavezno\r\nneobavezno, poželjno).");
            // 
            // txtNacinProvjere
            // 
            this.txtNacinProvjere.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNacinProvjere.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNacinProvjere.Location = new System.Drawing.Point(254, 365);
            this.txtNacinProvjere.Multiline = true;
            this.txtNacinProvjere.Name = "txtNacinProvjere";
            this.txtNacinProvjere.Size = new System.Drawing.Size(380, 89);
            this.txtNacinProvjere.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.SteelBlue;
            this.label9.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(251, 1);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(386, 24);
            this.label9.TabIndex = 15;
            this.label9.Text = "Oznaka";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.SteelBlue;
            this.tableLayoutPanel1.SetColumnSpan(this.label8, 2);
            this.label8.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1, 1);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(249, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Atribut";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label4, 2);
            this.label4.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 362);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 95);
            this.label4.TabIndex = 6;
            this.label4.Text = "Način provjere:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipNacinProvjere.SetToolTip(this.label4, resources.GetString("label4.ToolTip"));
            // 
            // txtIdentifikator
            // 
            this.txtIdentifikator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdentifikator.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentifikator.Location = new System.Drawing.Point(254, 29);
            this.txtIdentifikator.Name = "txtIdentifikator";
            this.txtIdentifikator.Size = new System.Drawing.Size(380, 23);
            this.txtIdentifikator.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label11, 2);
            this.label11.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1, 142);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(249, 29);
            this.label11.TabIndex = 17;
            this.label11.Text = "Vrsta zahtjeva:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipVrstaZahtjeva.SetToolTip(this.label11, "Neka od vrsta zahtjeva s obzirom na klasifikaciju koju autori koriste. \r\nNpr. fun" +
        "kcionalni, nefunkcionalni...");
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label10, 2);
            this.label10.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1, 113);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(249, 28);
            this.label10.TabIndex = 14;
            this.label10.Text = "Datum zahtjeva:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipDatumZahtjeva.SetToolTip(this.label10, "Datum kojeg ste kreirali zahtjev.");
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label7, 2);
            this.label7.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1, 291);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(249, 40);
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
            this.txtPrioritet.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrioritet.Location = new System.Drawing.Point(254, 264);
            this.txtPrioritet.Name = "txtPrioritet";
            this.txtPrioritet.Size = new System.Drawing.Size(380, 23);
            this.txtPrioritet.TabIndex = 10;
            // 
            // txtObrazlozenje
            // 
            this.txtObrazlozenje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObrazlozenje.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObrazlozenje.Location = new System.Drawing.Point(254, 175);
            this.txtObrazlozenje.Multiline = true;
            this.txtObrazlozenje.Name = "txtObrazlozenje";
            this.txtObrazlozenje.Size = new System.Drawing.Size(380, 82);
            this.txtObrazlozenje.TabIndex = 5;
            // 
            // txtVrsta
            // 
            this.txtVrsta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVrsta.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVrsta.Location = new System.Drawing.Point(254, 145);
            this.txtVrsta.Name = "txtVrsta";
            this.txtVrsta.Size = new System.Drawing.Size(380, 23);
            this.txtVrsta.TabIndex = 14;
            // 
            // dtpDatumZahjteva
            // 
            this.dtpDatumZahjteva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtpDatumZahjteva.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatumZahjteva.Location = new System.Drawing.Point(344, 116);
            this.dtpDatumZahjteva.Name = "dtpDatumZahjteva";
            this.dtpDatumZahjteva.Size = new System.Drawing.Size(200, 22);
            this.dtpDatumZahjteva.TabIndex = 16;
            // 
            // txtZahtjev
            // 
            this.txtZahtjev.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtZahtjev.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZahtjev.Location = new System.Drawing.Point(254, 59);
            this.txtZahtjev.Multiline = true;
            this.txtZahtjev.Name = "txtZahtjev";
            this.txtZahtjev.Size = new System.Drawing.Size(380, 50);
            this.txtZahtjev.TabIndex = 3;
            // 
            // txtIzvor
            // 
            this.txtIzvor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIzvor.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIzvor.Location = new System.Drawing.Point(254, 294);
            this.txtIzvor.Multiline = true;
            this.txtIzvor.Name = "txtIzvor";
            this.txtIzvor.Size = new System.Drawing.Size(380, 34);
            this.txtIzvor.TabIndex = 13;
            // 
            // btnProvjeriZahtjev
            // 
            this.btnProvjeriZahtjev.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProvjeriZahtjev.Image = ((System.Drawing.Image)(resources.GetObject("btnProvjeriZahtjev.Image")));
            this.btnProvjeriZahtjev.Location = new System.Drawing.Point(200, 56);
            this.btnProvjeriZahtjev.Margin = new System.Windows.Forms.Padding(0);
            this.btnProvjeriZahtjev.Name = "btnProvjeriZahtjev";
            this.btnProvjeriZahtjev.Size = new System.Drawing.Size(50, 56);
            this.btnProvjeriZahtjev.TabIndex = 21;
            this.toolTipGumbProvjeriZahtjev.SetToolTip(this.btnProvjeriZahtjev, "Kliknite na ovaj gumb kada napišete zahtjev kako biste provjerili ispravnost. ");
            this.btnProvjeriZahtjev.UseVisualStyleBackColor = true;
            this.btnProvjeriZahtjev.Click += new System.EventHandler(this.btnProvjeriZahtjev_Click);
            // 
            // btnSpremiZahtjev
            // 
            this.btnSpremiZahtjev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSpremiZahtjev.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSpremiZahtjev.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpremiZahtjev.Location = new System.Drawing.Point(505, 552);
            this.btnSpremiZahtjev.Name = "btnSpremiZahtjev";
            this.btnSpremiZahtjev.Size = new System.Drawing.Size(100, 55);
            this.btnSpremiZahtjev.TabIndex = 10;
            this.btnSpremiZahtjev.Text = "Spremi zahtjev";
            this.btnSpremiZahtjev.UseVisualStyleBackColor = false;
            this.btnSpremiZahtjev.Click += new System.EventHandler(this.btnSpremiZahtjev_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOdustani.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOdustani.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdustani.Location = new System.Drawing.Point(611, 552);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(100, 55);
            this.btnOdustani.TabIndex = 11;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
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
            // toolTipDatumZahtjeva
            // 
            this.toolTipDatumZahtjeva.IsBalloon = true;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 588);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(322, 15);
            this.label13.TabIndex = 12;
            this.label13.Text = "*Prijeđite mišem preko atributa kako biste saznali više informacija.";
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
            // toolTipGumbProvjeriZahtjev
            // 
            this.toolTipGumbProvjeriZahtjev.IsBalloon = true;
            // 
            // txtOdgovorAPIa
            // 
            this.txtOdgovorAPIa.Location = new System.Drawing.Point(742, 89);
            this.txtOdgovorAPIa.Multiline = true;
            this.txtOdgovorAPIa.Name = "txtOdgovorAPIa";
            this.txtOdgovorAPIa.ReadOnly = true;
            this.txtOdgovorAPIa.Size = new System.Drawing.Size(286, 456);
            this.txtOdgovorAPIa.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(738, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 31);
            this.label5.TabIndex = 14;
            this.label5.Text = "Provjera zahtjeva:";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1030, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(197, 31);
            this.label14.TabIndex = 16;
            this.label14.Text = "Alternativne formulacije:";
            // 
            // txtAlternative
            // 
            this.txtAlternative.Location = new System.Drawing.Point(1034, 89);
            this.txtAlternative.Multiline = true;
            this.txtAlternative.Name = "txtAlternative";
            this.txtAlternative.ReadOnly = true;
            this.txtAlternative.Size = new System.Drawing.Size(193, 149);
            this.txtAlternative.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1030, 241);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(197, 31);
            this.label15.TabIndex = 18;
            this.label15.Text = "Povezani zahtjevi:";
            // 
            // txtPovezaniZahtjevi
            // 
            this.txtPovezaniZahtjevi.Location = new System.Drawing.Point(1034, 275);
            this.txtPovezaniZahtjevi.Multiline = true;
            this.txtPovezaniZahtjevi.Name = "txtPovezaniZahtjevi";
            this.txtPovezaniZahtjevi.ReadOnly = true;
            this.txtPovezaniZahtjevi.Size = new System.Drawing.Size(193, 271);
            this.txtPovezaniZahtjevi.TabIndex = 17;
            // 
            // FrmNoviZahtjev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1285, 612);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtPovezaniZahtjevi);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtAlternative);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtOdgovorAPIa);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremiZahtjev);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.labelZahtjev);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNoviZahtjev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novi zahtjev";
            this.Load += new System.EventHandler(this.FrmNoviZahtjev_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelZahtjev;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSpremiZahtjev;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.ToolTip toolTipID;
        private System.Windows.Forms.ToolTip toolTipZahtjev;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolTip toolTipDatumZahtjeva;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolTip toolTipVrstaZahtjeva;
        private System.Windows.Forms.ToolTip toolTipObrazloženje;
        private System.Windows.Forms.ToolTip toolTipPrioritet;
        private System.Windows.Forms.ToolTip toolTipIzvor;
        private System.Windows.Forms.ToolTip toolTipStatus;
        private System.Windows.Forms.ToolTip toolTipNacinProvjere;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtNacinProvjere;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdentifikator;
        private System.Windows.Forms.TextBox txtPrioritet;
        private System.Windows.Forms.TextBox txtObrazlozenje;
        private System.Windows.Forms.TextBox txtVrsta;
        private System.Windows.Forms.DateTimePicker dtpDatumZahjteva;
        private System.Windows.Forms.TextBox txtZahtjev;
        private System.Windows.Forms.TextBox txtIzvor;
        private System.Windows.Forms.Button btnProvjeriZahtjev;
        private System.Windows.Forms.ToolTip toolTipGumbProvjeriZahtjev;
        private System.Windows.Forms.TextBox txtOdgovorAPIa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtAlternative;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPovezaniZahtjevi;
    }
}