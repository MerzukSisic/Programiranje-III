namespace FIT.WinForms.Ispit
{
    partial class frmGradovi
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
            pbZastava = new PictureBox();
            lblDrzava = new Label();
            label2 = new Label();
            tbNazivGrada = new TextBox();
            btnDodaj = new Button();
            dgvGradovi = new DataGridView();
            Naziv = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            PromjeniStatus = new DataGridViewButtonColumn();
            gbGenerator = new GroupBox();
            label1 = new Label();
            tbBrojGradova = new TextBox();
            cbStatus = new CheckBox();
            btnGenerisi = new Button();
            label3 = new Label();
            tbInfo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbZastava).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGradovi).BeginInit();
            gbGenerator.SuspendLayout();
            SuspendLayout();
            // 
            // pbZastava
            // 
            pbZastava.Location = new Point(12, 12);
            pbZastava.Name = "pbZastava";
            pbZastava.Size = new Size(115, 81);
            pbZastava.SizeMode = PictureBoxSizeMode.StretchImage;
            pbZastava.TabIndex = 0;
            pbZastava.TabStop = false;
            // 
            // lblDrzava
            // 
            lblDrzava.AutoSize = true;
            lblDrzava.Location = new Point(133, 44);
            lblDrzava.Name = "lblDrzava";
            lblDrzava.Size = new Size(38, 15);
            lblDrzava.TabIndex = 1;
            lblDrzava.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 112);
            label2.Name = "label2";
            label2.Size = new Size(149, 15);
            label2.TabIndex = 1;
            label2.Text = "Unesite naziv novog grada:";
            // 
            // tbNazivGrada
            // 
            tbNazivGrada.Location = new Point(167, 109);
            tbNazivGrada.Name = "tbNazivGrada";
            tbNazivGrada.Size = new Size(119, 23);
            tbNazivGrada.TabIndex = 2;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(292, 108);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(75, 23);
            btnDodaj.TabIndex = 3;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // dgvGradovi
            // 
            dgvGradovi.AllowUserToAddRows = false;
            dgvGradovi.AllowUserToDeleteRows = false;
            dgvGradovi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGradovi.Columns.AddRange(new DataGridViewColumn[] { Naziv, Aktivan, PromjeniStatus });
            dgvGradovi.Location = new Point(12, 138);
            dgvGradovi.Name = "dgvGradovi";
            dgvGradovi.ReadOnly = true;
            dgvGradovi.RowTemplate.Height = 25;
            dgvGradovi.Size = new Size(355, 150);
            dgvGradovi.TabIndex = 4;
            dgvGradovi.CellContentClick += dgvGradovi_CellContentClick;
            // 
            // Naziv
            // 
            Naziv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Naziv.DataPropertyName = "Naziv";
            Naziv.HeaderText = "Naziv grada";
            Naziv.Name = "Naziv";
            Naziv.ReadOnly = true;
            // 
            // Aktivan
            // 
            Aktivan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Aktivan.DataPropertyName = "Status";
            Aktivan.HeaderText = "Aktivan";
            Aktivan.Name = "Aktivan";
            Aktivan.ReadOnly = true;
            // 
            // PromjeniStatus
            // 
            PromjeniStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PromjeniStatus.DataPropertyName = "PromjeniStatus";
            PromjeniStatus.HeaderText = "";
            PromjeniStatus.Name = "PromjeniStatus";
            PromjeniStatus.ReadOnly = true;
            PromjeniStatus.Text = "Promjeni status";
            PromjeniStatus.UseColumnTextForButtonValue = true;
            // 
            // gbGenerator
            // 
            gbGenerator.Controls.Add(cbStatus);
            gbGenerator.Controls.Add(label3);
            gbGenerator.Controls.Add(label1);
            gbGenerator.Controls.Add(btnGenerisi);
            gbGenerator.Controls.Add(tbInfo);
            gbGenerator.Controls.Add(tbBrojGradova);
            gbGenerator.Location = new Point(12, 306);
            gbGenerator.Name = "gbGenerator";
            gbGenerator.Size = new Size(355, 175);
            gbGenerator.TabIndex = 5;
            gbGenerator.TabStop = false;
            gbGenerator.Text = "Generator";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 1;
            label1.Text = "Broj gradova:";
            // 
            // tbBrojGradova
            // 
            tbBrojGradova.Location = new Point(89, 26);
            tbBrojGradova.Name = "tbBrojGradova";
            tbBrojGradova.Size = new Size(54, 23);
            tbBrojGradova.TabIndex = 2;
            // 
            // cbStatus
            // 
            cbStatus.AutoSize = true;
            cbStatus.Location = new Point(149, 29);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(63, 19);
            cbStatus.TabIndex = 3;
            cbStatus.Text = "Aktivni";
            cbStatus.UseVisualStyleBackColor = true;
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(218, 22);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(75, 23);
            btnGenerisi.TabIndex = 3;
            btnGenerisi.Text = "Generiši";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += btnGenerisi_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 53);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 1;
            label3.Text = "Info";
            // 
            // tbInfo
            // 
            tbInfo.Location = new Point(6, 71);
            tbInfo.Multiline = true;
            tbInfo.Name = "tbInfo";
            tbInfo.Size = new Size(343, 98);
            tbInfo.TabIndex = 2;
            // 
            // frmGradovi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 493);
            Controls.Add(gbGenerator);
            Controls.Add(dgvGradovi);
            Controls.Add(btnDodaj);
            Controls.Add(tbNazivGrada);
            Controls.Add(label2);
            Controls.Add(lblDrzava);
            Controls.Add(pbZastava);
            Name = "frmGradovi";
            Text = "Podaci o gradu";
            Load += frmGradovi_Load;
            ((System.ComponentModel.ISupportInitialize)pbZastava).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGradovi).EndInit();
            gbGenerator.ResumeLayout(false);
            gbGenerator.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbZastava;
        private Label lblDrzava;
        private Label label2;
        private TextBox tbNazivGrada;
        private Button btnDodaj;
        private DataGridView dgvGradovi;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn PromjeniStatus;
        private GroupBox gbGenerator;
        private CheckBox cbStatus;
        private Label label3;
        private Label label1;
        private Button btnGenerisi;
        private TextBox tbInfo;
        private TextBox tbBrojGradova;
    }
}