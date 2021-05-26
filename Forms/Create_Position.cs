using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1.Forms
{
    public partial class Create_Position : Form
    {
        public Create_Position()
        {
            InitializeComponent();
        }

        private void Create_Position_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Lists.MenuaName_list.Count; i++)
            {
                cmbListMenueNames.Items.Add(Lists.MenuaName_list[i].MenueName);
            }
        }

        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            Bitmap image;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files(*.JPG;)|*.JPG;" + "|All files(*.*)|*.*";
            dialog.CheckFileExists = true;
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(dialog.FileName);
                iconPictureBox1.Image = (Image)image;

                byte[] imageArray = File.ReadAllBytes(dialog.FileName);
                base64Operations.base64 = Convert.ToBase64String(imageArray);
                //iconPictureBox1.Text = base64Text;


            }
        }

        private void btnCreatePosition_Click(object sender, EventArgs e)
        {
            bool check = true;
            bool check1 = true;
            bool check2 = true;
            
            if (textName.Text.Length>20 || textName.Text.Length<3 || textName.Text.Trim().Length == 0)
            {
                check = false;
            }
            if (textDescription.Text.Length > 100 || textDescription.Text.Length < 5 || textDescription.Text.Trim().Length == 0)
            {
                check1 = false;
            }
            if(check == false && check1 == false)
            {
                MessageBox.Show("Введенные данные для названия и описания не соответсвуют заданным нормам\nВозможно они слишком длинные, попробуйте сделать их короче", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (check == false)
            {
                MessageBox.Show("Введенное название не соответсвует заданным нормам\nВозможно оно слишком длинное, попробуйте сделать его короче", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (check1 == false)
            {
                MessageBox.Show("Введенные данные для описания не соответсвуют заданным нормам\nВозможно оно слишком длинное, попробуйте сделать его немного короче", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (base64Operations.base64.Length == 0)
            {
                MessageBox.Show("Необходимо добавить изображение", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (cmbListMenueNames.SelectedItem==null)
            {
                MessageBox.Show("Необходимо выбрать МЕНЮ", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                check2 = false;
            }
            if (cmbListCategoris.SelectedItem == null)
            {
                MessageBox.Show("Необходимо выбрать КАТЕГОРИЮ", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                check2 = false;
            }
            if (textPrice.Text.Length == 0)
            {
                MessageBox.Show("Необходимо ввести ЦЕНУ", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                check2 = false;
            }
            if (textCaloris.Text.Length == 0)
            {
                MessageBox.Show("Необходимо ввести число КАЛОРИЙ", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                check2 = false;
            }
            if (check==true && check1==true && check2==true)
            {
                Lists.FoodPositions_list.Add(new MenueFood_position(cmbListMenueNames.SelectedItem.ToString(), cmbListCategoris.SelectedItem.ToString(), textName.Text, textDescription.Text, Convert.ToDouble(textPrice.Text), Convert.ToInt32(textCaloris.Text), base64Operations.base64));
                MessageBox.Show("Позиция добавлена", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbListMenueNames.SelectedItem = null;
                cmbListCategoris.SelectedItem = null;
                textName.Text = "";
                textDescription.Text = "";
                textPrice.Text = "";
                textCaloris.Text = "";
                base64Operations.base64 = "";
                JsonOperations.WritingToJsonMenueFoodPositions("MenueFood_Positions_Jason.json", Lists.FoodPositions_list);
            }
        
        }

        private void textPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая ASCII
            {
                e.Handled = true;
            }
        }

        private void textCaloris_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 ) //цифры, клавиша BackSpace ASCII
            {
                e.Handled = true;
            }
        }
    }
}
