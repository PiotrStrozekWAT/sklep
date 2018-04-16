using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKLEP
{
    public partial class Form1 : Form
    {
        SKLEPEntities sklepEntities = new SKLEPEntities();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            //DbSet<Drukarki> drukarki = sklepEntities.Drukarki;
            //DbSet<Produkty> produkty = sklepEntities.Produkty;

            var drukprod = (from d in sklepEntities.Drukarki
                            join p in sklepEntities.Produkty on d.model equals p.model
                            //where d.kolor_boolean == true
                            select new
                            {
                                model = d.model,
                                typ = d.typ,
                                kolor_boolean = d.kolor_boolean,
                                cena = d.cena,
                                producent = p.producent,
                            }).ToList();

            dataGridView1.DataSource = drukprod;
            //drukarkiBindingSource.DataSource = sklepEntities.Drukarki.ToList();
    
        }
       
    }
}
