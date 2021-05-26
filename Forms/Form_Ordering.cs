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
    public partial class Form_Ordering : Form
    {
        public Form_Ordering()
        {
            InitializeComponent();
        }

        private void Form_Ordering_Load(object sender, EventArgs e)
        {
            OrderingOperations.AvailableOrder = false;
            OrderingOperations.Number = 0;
            for (int i=0; i<Lists.FoodPositions_list.Count; i++ )
            {
                if (Lists.FoodPositions_list[i].Menue_name == OrderingOperations.MenuChois && Lists.FoodPositions_list[i].Category == OrderingOperations.MenueFoodCategoryChois)
                {
                    Lists.ListForOrdering.Add(Lists.FoodPositions_list[i]);
                }
            }
            if (Lists.ListForOrdering.Count > 0)
            {
                ShowPosition();
                OrderingOperations.AvailableOrder = true;
            }
            
            //MessageBox.Show($"{ Lists.ListForOrdering.Count}", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if(OrderingOperations.AvailableOrder == true)
            {
                Lists.ShoppingList.Add(Lists.ListForOrdering[OrderingOperations.Number]);
            }


        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            OrderingOperations.AvailableOrder = false;
            OrderingOperations.Number++;
            if (OrderingOperations.Number < Lists.ListForOrdering.Count)
            {
                
                ShowPosition();
                OrderingOperations.AvailableOrder = true;
            }
            else
            {
                OrderingOperations.Number--;
            }
           
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            OrderingOperations.AvailableOrder = false;
            OrderingOperations.Number--;
            if (OrderingOperations.Number >= 0 )
            {
               
                ShowPosition();
                OrderingOperations.AvailableOrder = true;
            }
            else
            {
                OrderingOperations.Number++;
            }
            
        }
        private void ShowPosition()
        {
            //for (int i = 0; i < Lists.ListForOrdering.Count; i++)
            //{

            //}
            lbName.Text = Lists.ListForOrdering[OrderingOperations.Number].Food_name;
            lbAbout.Text = Lists.ListForOrdering[OrderingOperations.Number].Food_about;
            lbPrise.Text = Lists.ListForOrdering[OrderingOperations.Number].Price.ToString();
            lbCaloris.Text = Lists.ListForOrdering[OrderingOperations.Number].Calories.ToString();
            iconPictureBox1.Image = base64Operations.Base64ToImage(Lists.ListForOrdering[OrderingOperations.Number].Image_64);
        }
    }
}
