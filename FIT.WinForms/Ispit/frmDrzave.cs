using FIT.Data.Ispit;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
using FIT.WinForms.Ispit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace FIT.WinForms
{
    public partial class frmDrzave : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        private Timer timer;
        List<Drzave> DrzavePodaci = new List<Drzave>();
        public frmDrzave()
        {
            InitializeComponent();
            dgvDrzave.AutoGenerateColumns = false;
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += (sender, e) => lblVrijeme.Text = DateTime.Now.ToString("HH:mm:ss");
            timer.Start();
        }

        private void frmDrzave_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            DrzavePodaci = db.Drzave.ToList();
            if (DrzavePodaci != null)
            {
                var tabela = new DataTable();
                tabela.Columns.Add("Zastava", typeof(Image));
                tabela.Columns.Add("Naziv");
                tabela.Columns.Add("BrojGradova");
                tabela.Columns.Add("Aktivna");
                for (int i = 0; i < DrzavePodaci.Count; i++)
                {
                    var drzava = DrzavePodaci[i];
                    var red = tabela.NewRow();
                    red["Zastava"] = Ekstenzije.ToImage(drzava.Zastava);
                    red["Naziv"] = drzava.Naziv.ToString();
                    red["BrojGradova"] = db.Gradovi.Where(x => x.DrzavaId == drzava.Id).Count().ToString();
                    red["Aktivna"] = drzava.Status;
                    tabela.Rows.Add(red);
                }
                dgvDrzave.DataSource = null;
                dgvDrzave.DataSource = tabela;
            }
        }

        private void btnNovaDrzava_Click(object sender, EventArgs e)
        {
            var novaForma = new frmNovaDrzava(null);
            novaForma.ShowDialog();
            UcitajPodatke();
        }

        private void dgvDrzave_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex ==4)
            {
                var novaForma = new frmGradovi(DrzavePodaci[e.RowIndex]);
                novaForma.ShowDialog();
                UcitajPodatke();
            }
            else
            {
                var novaForma = new frmNovaDrzava(DrzavePodaci[e.RowIndex]);
                novaForma.ShowDialog();
                UcitajPodatke();
            }

        }
    }
}
