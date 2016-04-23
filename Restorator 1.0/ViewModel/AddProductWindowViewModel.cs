using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using Restorator.Commands;
using Restorator.DataAcces;
using Restorator.Model;
using Restorator.View;

namespace Restorator.ViewModel
{
    internal class AddProductWindowViewModel : ViewModelBase
    {
        private string _name;
        private string _description;
        private int? _price;
        private int? _count;
        private AddProductWindow _addProductWindow;

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

        public int? Count
        {
            get { return _count; }
            set
            {
                _count = value;
                OnPropertyChanged(nameof(Count));
            }
        }

        public ICommand SaveProductCommand { get; set; }
        public ICommand ClearTextCommand { get; set; }

        public AddProductWindowViewModel()
        {
            AddProductWindowOnLoaded();
            SaveProductCommand = new DelegateCommand(arg => SaveProduct());
            ClearTextCommand = new DelegateCommand(arg => ClearText());
        }

        private void AddProductWindowOnLoaded()
        {
            var windows = Application.Current.Windows;
            foreach (var win in windows.OfType<AddProductWindow>())
            {
                _addProductWindow = win;
                _addProductWindow.Closed += AddProductWindowOnClosed;
            }
        }

        private void AddProductWindowOnClosed(object sender, EventArgs eventArgs)
        {
            _addProductWindow.Hide();
            var windows = Application.Current.Windows;
            foreach (var depotWindow in windows.OfType<DepotWindow>())
            {
                depotWindow.Show();
            }
        }

        private async void SaveProduct()
        {
            using (var context = new RestoratorDb())
            {
                var product = new Product(Name, Description, Price, Count);
                context.Products.Add(product);
                MessageBox.Show("Product added to the database!");
                await context.SaveChangesAsync();
            }
            ClearText();
            _addProductWindow.Hide();
            var windows = Application.Current.Windows;
            foreach (var depotWindow in windows.OfType<DepotWindow>())
            {
                depotWindow.Show();
            }
        }

        private void ClearText()
        {
            Name = null;
            Description = null;
            Price = null;
            Count = null;
        }
    }
}
