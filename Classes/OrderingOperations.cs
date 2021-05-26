using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Classes
{
    public class OrderingOperations
    {
        public static string MenuChois = "";
        public static string MenueFoodCategoryChois = "";
        public static bool AvailableOrder = false;
        public static int Number = 0;

        public static void CheckChoiceOfMenu(string Menu)
        {
            if (Menu=="")
            {
                MessageBox.Show("Сначала необходимо выбрать меню", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
