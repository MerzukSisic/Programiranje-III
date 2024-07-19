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
    public partial class frmGradovi : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        private Drzave drzave;
        List<Gradovi> GradoviPodaci = new List<Gradovi>();

        public frmGradovi(Drzave drzave)
        {
            InitializeComponent();
            this.drzave = drzave;
            dgvGradovi.AutoGenerateColumns = false;
        }

        private void frmGradovi_Load(object sender, EventArgs e)
        {
            lblDrzava.Text = drzave.Naziv.ToString();
            pbZastava.Image = Ekstenzije.ToImage(drzave.Zastava);
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            GradoviPodaci = db.Gradovi.Where(x => x.DrzavaId == drzave.Id).ToList();
            dgvGradovi.DataSource = null;
            dgvGradovi.DataSource = GradoviPodaci;
        }

        private void dgvGradovi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                var grad = GradoviPodaci[e.RowIndex];
                if (grad.Status == false)
                {
                    grad.Status = true;
                }
                else
                {
                    grad.Status = false;
                }
                db.Gradovi.Update(grad);
                db.SaveChanges();
                UcitajPodatke();

            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbNazivGrada.Text) && PostojiIsti())
            {
                var noviGrad = new Gradovi
                {
                    Naziv = tbNazivGrada.Text,
                    Status = true,
                    DrzavaId = drzave.Id
                };
                db.Gradovi.Add(noviGrad);
                db.SaveChanges();
                UcitajPodatke();
            }
        }

        private bool PostojiIsti()
        {
            var grad = db.Gradovi.Where(x => x.Naziv == tbNazivGrada.Text).ToList();
            if (grad.Count > 0)
            {
                MessageBox.Show("Grad koji ste unijeli već postoji u bazi");
                return false;
            }
            else
            {
                return true;
            }
        }

        private async void btnGenerisi_Click(object sender, EventArgs e)
        {
            int brojGradova;
            try
            {
                brojGradova = int.Parse(tbBrojGradova.Text);
            }catch(Exception ex)
            {
                MessageBox.Show("Niste unijeli broj");
                return;
            }
            var status = cbStatus.Checked;
            tbInfo.ScrollBars = ScrollBars.Vertical;
            var thread = new Thread(() => DodajThread(brojGradova, status));
            thread.Start();
        }

        private void DodajThread(int brojGradova, bool status)
        {
            for(int i=0; i < brojGradova; i++)
            {
                var noviGrad = new Gradovi { 
                    Naziv = $"Grad{i}",
                    Status = status,
                    DrzavaId = drzave.Id
                };
                db.Gradovi.Add(noviGrad);
                db.SaveChanges();
                Action ac = () =>
                {
                    tbInfo.Text += $"{DateTime.Now} -> dodat grad {noviGrad.Naziv} za državu {drzave.Naziv}" + Environment.NewLine;
                };
                BeginInvoke(ac);
                Thread.Sleep(300);
            }
            BeginInvoke(UcitajPodatke);
        }
    }
}
