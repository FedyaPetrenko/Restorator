namespace Restorator_1._0.Model
{
    public class Dish
    {
        private string _typeOfMeals;
        private string _name;
        private int _weight;
        private string _composition;
        private int _price;

        public string TypeOfMeals
        {
            get { return _typeOfMeals; }
            set { _typeOfMeals = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public string Composition
        {
            get { return _composition; }
            set { _composition = value; }
        }

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public Dish()
        {
        }

        public Dish(string typeOfMeals, string name, int weight, string composition, int price)
        {
            TypeOfMeals = typeOfMeals;
            Name = name;
            Weight = weight;
            Composition = composition;
            Price = price;
        }
    }
}
