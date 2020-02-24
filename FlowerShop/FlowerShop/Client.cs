using System;
using System.Collections.Generic;
using System.Text;

namespace FlowerShop
{
    public class Client : IClient
    {
        public int Id { get; }

        public string Name { get; private set; }

        public string Cellphone { get; private set; }

        public Client(IClientDAO dao, string name, string cell)
        {
            Name = name;
            Cellphone = cell;
            Id = dao.AddClient(name, cell);
        }
    }
}
