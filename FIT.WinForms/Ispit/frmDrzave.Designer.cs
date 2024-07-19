namespace FIT.WinForms
{
    partial class frmDrzave
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
            btnNovaDrzava = new Button();
            btnPrintaj = new Button();
            dgvDrzave = new DataGridView();
            Zastava = new DataGridViewImageColumn();
            Naziv = new DataGridViewTextBoxColumn();
            Aktivna = new DataGridViewCheckBoxColumn();
            BrojGradova = new DataGridViewTextBoxColumn();
            Gradovi = new DataGridViewButtonColumn();
            lblVrijeme = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDrzave).BeginInit();
            SuspendLayout();
            // 
            // btnNovaDrzava
            // 
            btnNovaDrzava.Location = new Point(634, 12);
            btnNovaDrzava.Name = "btnNovaDrzava";
            btnNovaDrzava.Size = new Size(128, 23);
            btnNovaDrzava.TabIndex = 0;
            btnNovaDrzava.Text = "Nova država";
            btnNovaDrzava.UseVisualStyleBackColor = true;
            btnNovaDrzava.Click += btnNovaDrzava_Click;
            // 
            // btnPrintaj
            // 
            btnPrintaj.Location = new Point(634, 338);
            btnPrintaj.Name = "btnPrintaj";
            btnPrintaj.Size = new Size(128, 23);
            btnPrintaj.TabIndex = 0;
            btnPrintaj.Text = "Printaj";
            btnPrintaj.UseVisualStyleBackColor = true;
            // 
            // dgvDrzave
            // 
            dgvDrzave.AllowUserToAddRows = false;
            dgvDrzave.AllowUserToDeleteRows = false;
            dgvDrzave.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDrzave.Columns.AddRange(new DataGridViewColumn[] { Zastava, Naziv, Aktivna, BrojGradova, Gradovi });
            dgvDrzave.Location = new Point(12, 41);
            dgvDrzave.Name = "dgvDrzave";
            dgvDrzave.ReadOnly = true;
            dgvDrzave.RowTemplate.Height = 25;
            dgvDrzave.Size = new Size(750, 291);
            dgvDrzave.TabIndex = 1;
            dgvDrzave.CellContentClick += dgvDrzave_CellContentClick;
            // 
            // Zastava
            // 
            Zastava.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Zastava.DataPropertyName = "Zastava";
            Zastava.HeaderText = "Zastava";
            Zastava.ImageLayout = DataGridViewImageCellLayout.Stretch;
            Zastava.Name = "Zastava";
            Zastava.ReadOnly = true;
            // 
            // Naziv
            // 
            Naziv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Naziv.DataPropertyName = "Naziv";
            Naziv.HeaderText = "Država";
            Naziv.Name = "Naziv";
            Naziv.ReadOnly = true;
            // 
            // Aktivna
            // 
            Aktivna.DataPropertyName = "Aktivna";
            Aktivna.HeaderText = "Aktivna";
            Aktivna.Name = "Aktivna";
            Aktivna.ReadOnly = true;
            // 
            // BrojGradova
            // 
            BrojGradova.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BrojGradova.DataPropertyName = "BrojGradova";
            BrojGradova.HeaderText = "Broj gradova";
            BrojGradova.Name = "BrojGradova";
            BrojGradova.ReadOnly = true;
            // 
            // Gradovi
            // 
            Gradovi.DataPropertyName = "Gradovi";
            Gradovi.HeaderText = "";
            Gradovi.Name = "Gradovi";
            Gradovi.ReadOnly = true;
            Gradovi.Text = "Gradovi";
            Gradovi.UseColumnTextForButtonValue = true;
            // 
            // lblVrijeme
            // 
            lblVrijeme.AutoSize = true;
            lblVrijeme.Location = new Point(12, 349);
            lblVrijeme.Name = "lblVrijeme";
            lblVrijeme.Size = new Size(38, 15);
            lblVrijeme.TabIndex = 2;
            lblVrijeme.Text = "label1";
            // 
            // frmDrzave
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 373);
            Controls.Add(lblVrijeme);
            Controls.Add(dgvDrzave);
            Controls.Add(btnPrintaj);
            Controls.Add(btnNovaDrzava);
            Name = "frmDrzave";
            Text = "Države";
            Load += frmDrzave_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDrzave).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNovaDrzava;
        private Button btnPrintaj;
        private DataGridView dgvDrzave;
        private Label lblVrijeme;
        private DataGridViewImageColumn Zastava;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewCheckBoxColumn Aktivna;
        private DataGridViewTextBoxColumn BrojGradova;
        private DataGridViewButtonColumn Gradovi;
    }
}