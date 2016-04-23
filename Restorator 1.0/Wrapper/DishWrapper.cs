using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restorator.Model;

namespace Restorator.Wrapper
{
    class DishWrapper : ModelWrapper<Dish>
    {
        public DishWrapper(Dish dishModel/*, Product productModel*/) : base(dishModel)
        {
            InitializeCollectionProperties(dishModel);
            //if (productModel == null)
            //{
            //    throw new ArgumentException("");
            //}
        }

        private void InitializeCollectionProperties(Dish model)
        {
            if (model.Products == null)
            {
                throw new ArgumentException("Products cannot be empty!");
            }
            Products = new ObservableCollection<ProductWrapper>(model.Products.Select(product => new ProductWrapper(product)));
        }

        public string Name
        {
            get { return GetValue<string>(); }
            set { SetValue(value);}
        }

        public string TypeOfMeals
        {
            get { return GetValue<string>(); }
            set { SetValue(value);}
        }

        public int? Weight
        {
            get { return GetValue<int?>(); }
            set { SetValue(value);}
        }

        public string Composition
        {
            get { return GetValue<string>(); }
            set { SetValue(value);}
        }

        public int Price
        {
            get { return GetValue<int>(); }
            set { SetValue(value);}
        }

        public ObservableCollection<ProductWrapper> Products { get; private set; }
        public ObservableCollection<OrderWrapper> Orders { get;private set; } 
    }
}
