using System;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using Restorator.Commands;
using Restorator.DataAcces;
using Restorator.Model;
using Restorator.View;

namespace Restorator.ViewModel
{
    internal class DepotWindowViewModel : ViewModelBase
    {
        private Product _selectedProduct;
        private ObservableCollection<Product> _products;
        private DepotWindow _depot;

        public ICommand DeleteCommand { get; set; }
        public ICommand AddCommand { get; set; }
        public ICommand RefreshCommand { get; set; }
        public ICommand SaveCommand { get; set; }

        public DepotWindowViewModel()
        {
            DepotOnLoaded();
            ShowAllProduts();
            DeleteCommand = new DelegateCommand(arg => DeleteSelectedProduct());
            AddCommand = new DelegateCommand(arg => AddProduct());
            RefreshCommand = new DelegateCommand(arg => ShowAllProduts());
            SaveCommand = new DelegateCommand(arg => ChangeSelectedProduct());
        }

        private async void ChangeSelectedProduct()
        {
            using (var context = new RestoratorDb())
            {
                var products = await context.Products.ToListAsync();
                for (var i = 0; i < Products.Count; i++)
                {
                    if (Products[i].Name != products[i].Name || Products[i].Description != products[i].Description ||
                        Products[i].Price != products[i].Price ||
                        Products[i].Count != products[i].Count && Products[i].ProductId == products[i].ProductId)
                    {
                        var product = Products[i];
                        products[i].Name = product.Name;
                        products[i].Description = product.Description;
                        products[i].Price = product.Price;
                        products[i].Count = product.Count;

                        context.Products.Attach(products[i]);
                        context.Entry(products[i]).State = EntityState.Modified;
                        await context.SaveChangesAsync();
                    }
                }
                MessageBox.Show("All information saved to database!");
            }
        }

        private void DepotOnLoaded()
        {
            var windows = Application.Current.Windows;
            foreach (var win in windows.OfType<DepotWindow>())
            {
                _depot = win;
                _depot.Closed += DepotOnClosed;
            }
        }

        private void DepotOnClosed(object sender, EventArgs eventArgs)
        {
            _depot.Hide();
            var windows = Application.Current.Windows;
            foreach (var startWindow in windows.OfType<StartWindow>())
            {
                startWindow.Show();
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

        private async void ShowAllProduts()
        {
            using (var context = new RestoratorDb())
            {
                Products = new ObservableCollection<Product>();
                foreach (var product in await context.Products.ToListAsync())
                {
                    Products.Add(product);
                }
            }
        }

        private async void DeleteSelectedProduct()
        {
            using (var context = new RestoratorDb())
            {
                if (SelectedProduct != null)
                    context.Products.Remove(await context.Products.FindAsync(SelectedProduct.ProductId));
                else
                    MessageBox.Show("Select one of the produts in the table!");
                await context.SaveChangesAsync();
                ShowAllProduts();
            }
        }

        private void AddProduct()
        {
            var addProductWindow = new AddProductWindow
            {
                DataContext = new AddProductWindowViewModel()
            };
            addProductWindow.Show();
        }
    }
}
