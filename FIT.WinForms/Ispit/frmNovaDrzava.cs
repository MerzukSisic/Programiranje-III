using FIT.Data;
using FIT.Data.Ispit;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.Ispit
{
    public partial class frmNovaDrzava : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        private Drzave drzave;

        public frmNovaDrzava(Drzave drzave)
        {
            InitializeComponent();
            this.drzave = drzave;
        }

        private void frmNovaDrzava_Load(object sender, EventArgs e)
        {
            if (drzave != null)
            {
                pbZastava.Image = Ekstenzije.ToImage(drzave.Zastava);
                tbZastava.Text = drzave.Naziv;
                cbStatus.Checked = drzave.Status;
            }
        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            if (ValidniPodaci())
            {
                if (drzave == null)
                {
                    var novaDrzava = new Drzave
                    {
                        Zastava = Ekstenzije.ToByteArray(pbZastava.Image),
                        Naziv = tbZastava.Text,
                        Status = cbStatus.Checked
                    };
                    db.Drzave.Add(novaDrzava);
                    db.SaveChanges();
                    Close();
                }
                else
                {
                    drzave.Zastava = Ekstenzije.ToByteArray(pbZastava.Image);
                    drzave.Naziv =tbZastava.Text;
                    drzave.Status = cbStatus.Checked;
                    db.Drzave.Update(drzave);
                    db.SaveChanges();
                    Close();
                }
            }
        }

        private bool ValidniPodaci()
        {
            return Helpers.Validator.ProvjeriUnos(pbZastava, err, Kljucevi.ReqiredValue) &&
                Helpers.Validator.ProvjeriUnos(tbZastava, err, Kljucevi.ReqiredValue);
        }

        private void pbZastava_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbZastava.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
