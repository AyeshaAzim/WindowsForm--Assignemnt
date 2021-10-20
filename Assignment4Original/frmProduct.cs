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
    public partial class frmProduct : Form
    {
        public event EventHandler<ProductEventArgs> NewProductItem;

        public frmProduct()
        {
            InitializeComponent();
        }

        private void gbProduct_Enter(object sender, EventArgs e)
        {
            cbCategory.DataSource = Enum.GetValues(typeof(Department));

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim()=="")
            {
                MessageBox.Show("Product Name Cannot be Blank ");
                txtName.Focus();
   
            }

            Product newProduct = new Product
            {
                Name = txtName.Text,
                Department = (Department)Enum.Parse(typeof(Department), cbCategory.Text, true),
                Price = numPrice.Value 

            };
            NewProductItem.Invoke(this, new ProductEventArgs(newProduct));
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
