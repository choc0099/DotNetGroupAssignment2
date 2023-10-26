using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment2
{
    class Dish
    {
        string dishName, price, calories, dishType, allergens, info;

        public Dish(string dishName, string price, string calories, string dishType, string allergens, string info)
        {
            this.dishName = dishName;
            this.price = price;
            this.calories = calories;
            this.dishType = dishType;
            this.allergens = allergens;
            this.info = info;
            StreamWriter file = new StreamWriter("dishDisplay.txt", true);
            file.WriteLine(dishName + "," + price + "," + calories + "," + dishType + "," + allergens + "," + info);
            file.Close();
        }

        public string getDishName()
        {
            return this.dishName;
        }
        public void setDishName(string dishName)
        {
            this.dishName = dishName;
        }

        public string getPrice()
        {
            return this.price;
        }
        public void setPice(string price)
        {
            this.price = price;
        }
        public string getCalories()
        {
            return this.calories;
        }
        public void setfname(string dishType)
        {
            this.dishType = dishType;
        }
        public string getAllergens()
        {
            return this.allergens;
        }
        public void setAllergens(string allergens)
        {
            this.allergens = allergens;
        }

        public string getInfo()
        {
            return this.info;
        }
        public void setEmail(string info)
        {
            this.info = info;
        }
       
        
        //---------------------------------------

        public List<Dish> getDishes()
        {
            String[] dishInfo = System.IO.File.ReadAllLines("dishDisplay.txt");
            List<Dish> dishes = new List<Dish>();

            try
            {
                foreach (string i in dishInfo)
                {
                    string[] temp = i.Split(',');
                    for (int g = 0; g < temp.Length; g = g + 6)
                    {
                        Dish dish = new Dish(temp[g], temp[g + 1], temp[g + 2], temp[g + 3], temp[g + 4], temp[g + 5]);
                        dishes.Add(dish);
                        //user.printUser();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadKey();
            }
            return dishes;
        }



    }
}
