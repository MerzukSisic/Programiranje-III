namespace FIT.WinForms.Ispit
{
    partial class frmNovaDrzava
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
            components = new System.ComponentModel.Container();
            btnSpasi = new Button();
            pbZastava = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            tbZastava = new TextBox();
            cbStatus = new CheckBox();
            openFileDialog1 = new OpenFileDialog();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbZastava).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // btnSpasi
            // 
            btnSpasi.Location = new Point(196, 303);
            btnSpasi.Name = "btnSpasi";
            btnSpasi.Size = new Size(75, 23);
            btnSpasi.TabIndex = 0;
            btnSpasi.Text = "Spasi";
            btnSpasi.UseVisualStyleBackColor = true;
            btnSpasi.Click += btnSpasi_Click;
            // 
            // pbZastava
            // 
            pbZastava.BackColor = SystemColors.ActiveCaption;
            pbZastava.Location = new Point(12, 27);
            pbZastava.Name = "pbZastava";
            pbZastava.Size = new Size(259, 142);
            pbZastava.SizeMode = PictureBoxSizeMode.StretchImage;
            pbZastava.TabIndex = 1;
            pbZastava.TabStop = false;
            pbZastava.Click += pbZastava_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 2;
            label1.Text = "Zastava:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 183);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 2;
            label2.Text = "Zastava:";
            // 
            // tbZastava
            // 
            tbZastava.Location = new Point(12, 201);
            tbZastava.Name = "tbZastava";
            tbZastava.Size = new Size(259, 23);
            tbZastava.TabIndex = 3;
            // 
            // cbStatus
            // 
            cbStatus.AutoSize = true;
            cbStatus.Location = new Point(12, 303);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(66, 19);
            cbStatus.TabIndex = 4;
            cbStatus.Text = "Aktivna";
            cbStatus.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmNovaDrzava
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(283, 333);
            Controls.Add(cbStatus);
            Controls.Add(tbZastava);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pbZastava);
            Controls.Add(btnSpasi);
            Name = "frmNovaDrzava";
            Text = "Podaci o državi";
            Load += frmNovaDrzava_Load;
            ((System.ComponentModel.ISupportInitialize)pbZastava).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSpasi;
        private PictureBox pbZastava;
        private Label label1;
        private Label label2;
        private TextBox tbZastava;
        private CheckBox cbStatus;
        private OpenFileDialog openFileDialog1;
        private ErrorProvider err;
    }
}