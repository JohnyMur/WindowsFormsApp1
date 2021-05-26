using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    public class MenueFood_position
    {
        public string Menue_name { get; set; }
        public string Category { get; set; }
        public string Food_name { get; set; }
        public string Food_about { get; set; }
        public double Price { get; set; }
        public int Calories { get; set; }
        public string Image_64 { get; set; }

        public MenueFood_position(string _menue_name, string _category, string _food_name, string _food_about, double _price, int _calories, string _image_64)
        {
            this.Menue_name = _menue_name;
            this.Category = _category;
            this.Food_name = _food_name;
            this.Food_about = _food_about;
            this.Price = _price;
            this.Calories = _calories;
            this.Image_64 = _image_64;
        }
    }
}
