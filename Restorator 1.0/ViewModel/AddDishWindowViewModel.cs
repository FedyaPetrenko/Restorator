using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Restorator.Commands;

namespace Restorator.ViewModel
{
    class AddDishWindowViewModel : ViewModelBase
    {
        public List<string> TypesOfMeal { get; set; } = new List<string> { "Select item...", "Cold dish", "Hot dish", "Salad", "Drink", "Dessert" };

        public List<string> ProductNamesList { get; set; }

        private string _name;
        private int? _weight;
        private int? _price;
        private ObservableCollection<string> products;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public int? Weight
        {
            get { return _weight; }
            set
            {
                _weight = value;
                OnPropertyChanged(nameof(Weight));
            }
        }

        public int? Price
        {
            get { return _price; }
            set
            {
                _price = value;
                OnPropertyChanged(nameof(Price));
            }
        }

        public ICommand ClearTextButtonCommand { get; set; }
        public ICommand SaveDishButtonCommand { get; set; }

        public AddDishWindowViewModel()
        {
            
            ClearTextButtonCommand = new DelegateCommand(arg => ClearText());
            SaveDishButtonCommand = new DelegateCommand(arg => SaveDish());
        }

        private void SaveDish()  
        {
            
        }

        private void ClearText()
        {
            Name = null;
            Weight = null;
            Price = null;
        }
    }
}
