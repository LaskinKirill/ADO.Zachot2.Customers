using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zachot.Customer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindingSource productBindingSource = new BindingSource(adventureWorks2017DataSet, "Product");
            ProductsGrid.DataSource = productBindingSource;
            bindingNavigator1.BindingSource = productBindingSource;
            productTableAdapter.Fill(adventureWorks2017DataSet.Product);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "adventureWorks2017DataSet.Product". При необходимости она может быть перемещена или удалена.
           this.productTableAdapter.Fill(this.adventureWorks2017DataSet.Product);
        }
    }
}
