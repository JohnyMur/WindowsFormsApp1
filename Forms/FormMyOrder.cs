using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1.Forms
{
    public partial class FormMyOrder : Form
    {
        public FormMyOrder()
        {
            InitializeComponent();
        }

        private void FormMyOrder_Load(object sender, EventArgs e)
        {
            double price = 0;
            int caloris = 0;
            DataTable table = new DataTable();
            table.Columns.Add("Название", typeof(string));
            table.Columns.Add("Цена", typeof(double));
            table.Columns.Add("Калории", typeof(int));
            for (int i = 0; i < Lists.ShoppingList.Count; i++)
            {
                table.Rows.Add(Lists.ShoppingList[i].Food_name, Lists.ShoppingList[i].Price, Lists.ShoppingList[i].Calories);
                dataGridView1.DataSource = table;

            }
            for (int i=0;i< Lists.ShoppingList.Count; i++ )
            {
                price += Lists.ShoppingList[i].Price;
                caloris+= Lists.ShoppingList[i].Calories;
            }
            lbPrice.Text = price.ToString();
            lbCaloris.Text = caloris.ToString();
        }
    }
}
