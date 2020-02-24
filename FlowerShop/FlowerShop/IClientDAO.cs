using System;
using System.Collections.Generic;
using System.Text;


namespace FlowerShop
{
    public interface IClientDAO
    {
        int ClientId(string name, string cell);
        int AddClient(string name, string cell);
        IClient GetClient(int id);
        void ChangeName(IClient client, string name);
        void ChangeCellphone(IClient client, string cellphone);
        void ChangeAddress(IClient client, string address);
    }
}
