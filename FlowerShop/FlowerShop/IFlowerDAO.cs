using System;
using System.Collections.Generic;
using System.Text;

namespace FlowerShop
{
    public interface IFlowerDAO
    {
        IFlower GetFlower(int id);
        int AddFlower(string description, double cost, int stock);
        int GetStock(IFlower id);
    }
}
