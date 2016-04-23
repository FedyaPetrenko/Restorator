using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restorator.Model;

namespace Restorator.Wrapper
{
    class GuestWrapper : ModelWrapper<Guest>
    {
        public GuestWrapper(Guest model) : base(model)
        {
        }

        public string FirstName
        {
            get { return GetValue<string>(); }
            set { SetValue(value);}
        }

        public string SecondName
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public string ThirdName
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public string PhoneNumber
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public string Email
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public int? PercentageDiscounts
        {
            get { return GetValue<int?>(); }
            set { SetValue(value); }
        }

        public long CardNumber
        {
            get { return GetValue<long>(); }
            set { SetValue(value); }
        }

        public string Password
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }
    }
}
