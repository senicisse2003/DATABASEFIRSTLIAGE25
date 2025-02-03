using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DATABASEFIRSTLIAGE25
{
    public partial class Form1 : Form
    {
        dbiagetabpaneEntities db;
        public Form1()
        {
            InitializeComponent();
            tabPage1.Text = "Categories";
            tabPage2.Text = "Products";
            db = new dbiagetabpaneEntities();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refresh();
            comboBox1.DataSource = db.Categories.ToList();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "CategoryId";

        }

        private void btnAddCategorie_Click(object sender, EventArgs e)
        {
            Categories categories = new Categories();
            categories.Name = txtLibelleCategorie.Text;
            db.Categories.Add(categories);
            db.SaveChanges();
            MessageBox.Show("donnees inserer");
            refresh();
        }

        private void refresh()
        {
            dataGridViewCategorie.DataSource = db.Categories.Select(c => new { Id = c.CategoryId, Libelle = c.Name }).ToList();
            dataGridViewProducts.DataSource = db.Products.Select(p => new { Id = p.ProductId, Libelle = p.Name, Prix = p.Price, Categorie = p.Categories.Name }).ToList();

        }

        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.Name = txtLibelleProducts.Text;
            products.Price =float.Parse(txtPrice.Text);
            var selected = (Categories)comboBox1.SelectedItem;
            products.Categories = db.Categories.FirstOrDefault(c => c.CategoryId == selected.CategoryId);
            products.CategoryId = selected.CategoryId;
           
            db.Products.Add(products);
            int result=db.SaveChanges();
            if (result>0)
            {
                MessageBox.Show("donnees inserer");
                refresh();


            }
            else
            {
                MessageBox.Show("verifier les donnees");
            }
        }

        private void txtPrice_Validating(object sender, CancelEventArgs e)
        {
            if(int.TryParse(txtPrice.Text, out int price))
            {
                if (price > 0)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtPrice, "valeur doit etre superieur a 0");
                }

            
                e.Cancel = false;
                errorProvider1.SetError(txtPrice, "");

            }
            else
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPrice, "valeur non valide");
            }
        }
    }
}
