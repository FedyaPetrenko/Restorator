using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Restorator.Commands;
using Restorator.DataAcces;
using Restorator.Model;
using Restorator.View;

namespace Restorator.ViewModel
{
    class DepotWindowViewModel : ViewModelBase
    {
        private Product _product;
        private Product _selectedProduct;
        private ObservableCollection<Product> _products;

        public ICommand RefreshCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand AddCommand { get; set; }

        public DepotWindowViewModel()
        {
            RefreshCommand = new DelegateCommand(arg => ShowAllProduts());
            DeleteCommand = new DelegateCommand(arg => DeleteSelectedProduct());
            //AddCommand = new DelegateCommand(arg => AddProduct());
            ShowAllProduts();
        }

        public Product Product
        {
            get { return _product; }
            set
            {
                _product = value;
                OnPropertyChanged(nameof(Product));
            }
        }

        public Product SelectedProduct
        {
            get { return _selectedProduct; }
            set
            {
                _selectedProduct = value;
                OnPropertyChanged(nameof(SelectedProduct));
            }
        }

        public ObservableCollection<Product> Products
        {
            get { return _products; }
            set
            {
                _products = value;
                OnPropertyChanged(nameof(Products));
            }
        }

        private void ShowAllProduts()
        {
            RestoratorEdm context = new RestoratorEdm();
            Products = new ObservableCollection<Product>();
            foreach (var product in context.Products.ToList())
            {
                Products.Add(product);
            }
        }

        private void DeleteSelectedProduct()
        {
            RestoratorEdm context = new RestoratorEdm();
            context.Products.Remove(SelectedProduct);
            context.SaveChangesAsync();
            ShowAllProduts();
        }

        //private void AddProduct()
        //{
        //    AddProductWindow addProductWindow = new AddProductWindow()
        //    {
        //        DataContext = new AddProductWindowViewModel()
        //    };
        //    addProductWindow.Show();
        //}
    }
}
