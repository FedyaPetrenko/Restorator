using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Restorator.Commands;
using Restorator_1._0.Model;

namespace Restorator.ViewModel
{
    class AddProductWindowViewModel : ViewModelBase
    {
        private int? _idDish;
        private string _barCode;
        private string _name;
        private string _description;
        private int? _price;

        public int? IdDish
        {
            get { return _idDish; }
            set
            {
                _idDish = value;
                OnPropertyChanged(nameof(IdDish));
            }
        }

        public string BarCode
        {
            get { return _barCode; }
            set
            {
                _barCode = value;
                OnPropertyChanged(nameof(BarCode));
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
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

        public ICommand SaveProductCommand { get; set; }
        public ICommand ClearTextCommand { get; set; }

        public AddProductWindowViewModel()
        {
            //SaveProductCommand = new DelegateCommand(arg => SaveProduct());
            ClearTextCommand = new DelegateCommand(arg => ClearText());
        }

        //private void SaveProduct()
        //{
        //    Connection connection = new Connection();
        //    if (connection.AddProduct(new Product(IdDish, BarCode, Name, Description, Price)))
        //        MessageBox.Show("Product added to the database!");
        //}

        private void ClearText()
        {
            IdDish = null;
            BarCode = null;
            Name = null;
            Description = null;
            Price = null;
        }
    }
}
