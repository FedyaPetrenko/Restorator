using System;
using System.Runtime.CompilerServices;
using Restorator.ViewModel;

namespace Restorator.Wrapper
{
    public class ModelWrapper<T> : Observable
    {
        public T Model { get; private set; }

        protected ModelWrapper(T model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }
            Model = model;
        }

        protected TValue GetValue<TValue>([CallerMemberName] string propertyName = null)
        {
            if (propertyName != null)
            {
                var propertyInfo = Model.GetType().GetProperty(propertyName);
                return (TValue) propertyInfo.GetValue(Model);
            }
            return default(TValue);
        }

        protected void SetValue<TValue>(TValue value, [CallerMemberName] string propertyName = null)
        {
            if (propertyName != null)
            {
                var propertyInfo = Model.GetType().GetProperty(propertyName);
                var currentValue = propertyInfo.GetValue(Model);

                if (!Equals(currentValue, value))
                {
                    propertyInfo.SetValue(Model, value);
                    OnPropertyChanged(propertyName);
                }
            }
        }
    }
}
