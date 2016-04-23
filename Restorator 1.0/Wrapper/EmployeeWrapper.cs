using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restorator.Model;

namespace Restorator.Wrapper
{
    class EmployeeWrapper : ModelWrapper<Employee>
    {
        public EmployeeWrapper(Employee model) : base(model)
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

        public string HomeAddress
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public long IdentificationCode
        {
            get { return GetValue<long>(); }
            set { SetValue(value); }
        }

        public string CardNumber
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public int Salary
        {
            get { return GetValue<int>(); }
            set { SetValue(value); }
        }

        public string Login
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public string Password
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }
    }
}
