using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace бабры_
{
    public partial class Data_viewer : Form
    {
        public Data_viewer()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trade2DataSet2.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter2.Fill(this.trade2DataSet2.Product);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_product fm = new Add_product(true);
            fm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Del fm = new Del();
            fm.Show();
        }
    }
}
