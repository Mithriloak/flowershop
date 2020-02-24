using System;
using System.Collections.Generic;
using System.Text;

namespace FlowerShop
{
    public interface IFlower : IIdentified
    {
        string Description { get; }
        double Cost { get; }
    }
}
