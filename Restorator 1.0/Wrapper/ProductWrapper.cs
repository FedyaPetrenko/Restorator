using System;
using System.Collections.ObjectModel;
using System.Linq;
using Restorator.Model;

namespace Restorator.Wrapper
{
    class ProductWrapper : ModelWrapper<Product>
    {
        public ProductWrapper(Product model) : base(model)
        {
            InitializeCollectionProperties(model);
        }

        private void InitializeCollectionProperties(Product model)
        {
            if (model.Dishes == null)
            {
                throw new ArgumentException("Dishes cannot be empty!");
            }
            //Dishes = new ObservableCollection<DishWrapper>(model.Dishes.Select(dish => new DishWrapper(dish)));
        }

        public string Name
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public string Description
        {
            get { return GetValue<string>(); }
            set { SetValue(value);}
        }

        public int? Price
        {
            get { return GetValue<int?>(); }
            set { SetValue(value);}
        }


        public int? Count
        {
            get { return GetValue<int?>(); }
            set { SetValue(value);}
        }

        public ObservableCollection<DishWrapper> Dishes { get; private set; }
    }
}
