using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
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

        public ICommand DeleteProductCommand { get; set; }
        public ICommand AddProductCommand { get; set; }
        public ICommand RefreshTableWithProductsCommand { get; set; }
        public ICommand SaveChangesInProductTableCommand { get; set; }

        public DepotWindowViewModel()
        {
            DepotInitializing();
            DeleteProductCommand = new DelegateCommand(arg => DeleteSelectedProduct());
            AddProductCommand = new DelegateCommand(arg => AddProduct());
            RefreshTableWithProductsCommand = new DelegateCommand(arg => ShowAllProduts());
            SaveChangesInProductTableCommand = new DelegateCommand(arg => SaveChangesInProducts());
        }

        private async void SaveChangesInProducts()
        {
            using (var context = new RestoratorDb())
            {
                var products = await context.Products.ToListAsync();
                for (var i = 0; i < Products.Count; i++)
                {
                    if (CheckForChangeInProduct(i, products))
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

        private bool CheckForChangeInProduct(int i, List<Product> products)
        {
            return Products[i].Name != products[i].Name || Products[i].Description != products[i].Description ||
                   Products[i].Price != products[i].Price ||
                   Products[i].Count != products[i].Count && Products[i].ProductId == products[i].ProductId;
        }

        private void DepotInitializing()
        {
            var windows = Application.Current.Windows;
            foreach (var win in windows.OfType<DepotWindow>())
            {
                _depot = win;
                _depot.Loaded += DepotOnLoaded;
                _depot.Closed += DepotOnClosed;
            }
        }

        private void DepotOnLoaded(object sender, RoutedEventArgs e)
        {
            Thread thread = new Thread(ShowAllProduts);
            thread.Start();
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

        private void ShowAllProduts()
        {
            ThreadStart threadStart = GetAllProductsFromDatabase;
            _depot.Dispatcher.BeginInvoke(DispatcherPriority.Normal, threadStart);
        }

        private async void GetAllProductsFromDatabase()
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
            }
            ShowAllProduts();
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
