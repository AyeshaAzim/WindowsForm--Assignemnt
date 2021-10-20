using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4Original
{
    public partial class frmCatalog : Form
    {
        Catalog newCatalog;
        public frmCatalog()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            
            
            if (txtCatalog.Text.Trim()=="")
            {
                MessageBox.Show(" Please provide the Catalog FileName !!!");
                txtCatalog.Focus();
                return;

            }
            
            dgvCatalog.Rows.Clear();
            try
            {
                newCatalog = DataStore.Load(txtCatalog.Text);

                if (txtFilter.Text.Length == 0)
                {
                    newCatalog._list = (List<Product>)newCatalog.GetAllProducts();
                }
                else
                {
                    newCatalog._list = (List<Product>)newCatalog.GetProducts(txtFilter.Text);
                }


                foreach (Product productItem in newCatalog._list)
                {

                    dgvCatalog.Rows.Add(productItem.Name, productItem.Department, productItem.Price);

                }

            }
            catch (Exception e1)
            {

                MessageBox.Show($"{e1.Message }  {e1.InnerException }");
            }
        }
        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                using (frmProduct productForm = new frmProduct())
                {
                    productForm.NewProductItem += ProductForm_NewProductItem;
                    if (productForm.ShowDialog() == DialogResult.OK)
                    {
                        ;
                    }
                }
            }
            catch (Exception e3)
            {

                MessageBox.Show(e3.Message);
            }
            
        }

        private void ProductForm_NewProductItem(object sender, ProductEventArgs e)
        {
            try
            {
                newCatalog.Add(e.NewProduct);
                dgvCatalog.Rows.Add(e.NewProduct.Name, e.NewProduct.Department, e.NewProduct.Price);
            }
            catch (Exception e4)
            {
                MessageBox.Show($"Error adding product! {e4.Message}");
                throw; 
            }
            
        }
        private void chkAutoSave_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutoSave.Checked  )
            {
                tmrAutoSave.Interval = Convert.ToInt32(numAutoSave.Value);
                tmrAutoSave.Enabled = true ;
                return;
            }
            else
            {
               
                
                tmrAutoSave.Enabled = false ;
                return;
            }
        }
        private void tmrAutoSave_Tick(object sender, EventArgs e)
        {

            if (dgvCatalog.Rows.Count != 0 && chkAutoSave.Checked )
            {
                DataStore.Save(newCatalog, txtCatalog.Text);
            }
        }
    }
}
