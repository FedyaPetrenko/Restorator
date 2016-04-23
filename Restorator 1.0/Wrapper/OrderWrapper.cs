using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restorator.Model;

namespace Restorator.Wrapper
{
    class OrderWrapper : ModelWrapper<Order>
    {
        public OrderWrapper(Order model) : base(model)
        {
        }


    }
}
