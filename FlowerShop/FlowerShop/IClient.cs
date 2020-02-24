using System;
using System.Collections.Generic;
using System.Text;

namespace FlowerShop
{
    public interface IClient : IIdentified
    {
        string Name { get; }
        string Cellphone { get; }
    }
}
