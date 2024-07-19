using FIT.Data;
using FIT.Data.Ispit;
using FIT.Infrastructure;
using Microsoft.Extensions.Logging.Abstractions;
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
    public partial class frmPretraga : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<Student> StudentiPodaci = new List<Student>();
        public frmPretraga()
        {
            InitializeComponent();
            dgvPretraga.AutoGenerateColumns = false;
        }

        private void frmPretraga_Load(object sender, EventArgs e)
        {
            cmbDrzava.DataSource = db.Drzave.ToList();
            cmbDrzava.SelectedIndex = -1;
        }

        private void cmbDrzava_SelectionChangeCommitted(object sender, EventArgs e)
        {
            UcitajPodatke();

        }

        private void UcitajPodatke()
        {
            var drzava = cmbDrzava.SelectedItem == null ? db.Drzave.First() : cmbDrzava.SelectedItem as Drzave;
            var gradovi = db.Gradovi.Where(x => x.DrzavaId == drzava.Id).ToList();

            if (gradovi.Count == 0)
            {
                MessageBox.Show($"Ne postoji niti jedan grad za odabranu državu {drzava.Naziv}!");
                dgvPretraga.DataSource = null;
            }

            var Trenutnigrad = cmbGrad.SelectedItem as Gradovi;

            cmbGrad.DataSource = gradovi;

            if (Trenutnigrad != null && gradovi.Any(x => x.Id == Trenutnigrad.Id))
            {
                cmbGrad.SelectedItem = gradovi.First(x => x.Id == Trenutnigrad.Id);
            }
            else
            {
                cmbGrad.SelectedItem = gradovi.FirstOrDefault();
            }

            var grad = cmbGrad.SelectedItem as Gradovi ?? gradovi.FirstOrDefault();
            if (grad == null)
            {
                MessageBox.Show("Nema grada");
                return;
            }

            StudentiPodaci = db.Studenti.Where(x => x.GradId == grad.Id).ToList();
            if (StudentiPodaci.Count == 0)
            {
                MessageBox.Show($"Ne postoji niti jedan student koji dolazi iz grada {grad.Naziv}");
                dgvPretraga.DataSource = null;
                cmbGrad.SelectedIndex = -1;
            }
            //harun meryzuk
            else
            {
                var tabela = new DataTable();
                tabela.Columns.Add("Ime");
                tabela.Columns.Add("Prezime");
                tabela.Columns.Add("Grad");
                tabela.Columns.Add("Drzava");
                tabela.Columns.Add("Prosjek");
                for(int i=0; i < StudentiPodaci.Count; i++)
                {
                    var student = StudentiPodaci[i];
                    var red = tabela.NewRow();
                    red["Ime"] = student.Ime.ToString();
                    red["Prezime"] = student.Prezime.ToString();
                    red["Grad"] = grad.Naziv.ToString();
                    red["Drzava"] = drzava.Naziv.ToString();
                    red["Prosjek"] = db.PolozeniPredmeti.Where(x => x.StudentId == student.Id).Count() == 0 ? "5" : db.PolozeniPredmeti.Where(x => x.StudentId == student.Id).Average(x => x.Ocjena).ToString();
                    tabela.Rows.Add(red);
                }
                dgvPretraga.DataSource = null;
                dgvPretraga.DataSource = tabela;
            }

        }

        private void cmbGrad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            UcitajPodatke();
        }
    }
}
