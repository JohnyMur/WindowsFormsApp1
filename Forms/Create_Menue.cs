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
    public partial class Create_Menue : Form
    {
        public Create_Menue()
        {
            
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool check = true;
            bool check1 = true;
            if (textMenueName.Text.Length<=20 && textMenueName.Text.Trim().Length!=0)
            {
                if (Lists.MenuaName_list.Count >= 1)
                {
                    for (int i=0;i< Lists.MenuaName_list.Count; i++)
                    {
                        if(textMenueName.Text== Lists.MenuaName_list[i].MenueName)
                        {
                            check = false;                
                        }
                    }
                }
              

            }
            else
            {
                MessageBox.Show("Название Меню слишком большое\nДайте меню другое название", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textMenueName.Text = "";
                check1 = false;
                check = false;
              

            }
            if (check == true)
            {
                Lists.MenuaName_list.Add(new Menue_Names_obj(textMenueName.Text));
                MessageBox.Show("Меню добавлено", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textMenueName.Text = "";
                listBox1.Items.Add(Lists.MenuaName_list[Lists.MenuaName_list.Count - 1].MenueName);
                JsonOperations.WritingToJsonMenueNames("MenueNames_Jason.json", Lists.MenuaName_list);

            }
            else if(check==false && check1==true)
            {
                MessageBox.Show("Меню с таким названием уже существует\nДайте меню другое название", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textMenueName.Text = "";
            }

        }

        private void Create_Menue_Load(object sender, EventArgs e)
        {
            for(int i=0;i < Lists.MenuaName_list.Count; i++)
            {
                listBox1.Items.Add(Lists.MenuaName_list[i].MenueName);
            }
           
            //cmbMenueList.DataSource = Lists.MenuaName_list;
            //cmbMenueList.ValueMember = "MenueName";
            //cmbMenueList.DisplayMember = "MenueName";

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string manuName = listBox1.SelectedItem.ToString();
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            for (int i = 0; i < Lists.MenuaName_list.Count; i++)
            {
                if (Lists.MenuaName_list[i].MenueName == manuName)
                {
                    Lists.MenuaName_list.RemoveAt(i);
                }
                //listBox1.Items.Add(Lists.MenuaName_list[i].MenueName);
            }
            JsonOperations.WritingToJsonMenueNames("MenueNames_Jason.json", Lists.MenuaName_list);
        }
    }
}
