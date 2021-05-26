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
    public partial class Form_Chois : Form
    {
        public Form_Chois()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Необходимо выбрать меню", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                OrderingOperations.MenuChois = listBox1.SelectedItem.ToString();
                MessageBox.Show($"Выбрано меню \"{listBox1.SelectedItem}\"", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
          
        }

        private void Form_Chois_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Lists.MenuaName_list.Count; i++)
            {
                listBox1.Items.Add(Lists.MenuaName_list[i].MenueName);
            }
        }
    }
}
