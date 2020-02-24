using System;
using System.Collections.Generic;
using System.Text;

namespace FlowerShop
{
    public interface IOrderDAO
    {
        IOrder GetOrder(int id);
        int AddOrder(IClient client);
        void AddFlower(IClient order, IClient flower);
        void SetDelivered(IOrder order);
        void RemoveFlower(IClient order, IClient flower);
    }
}
