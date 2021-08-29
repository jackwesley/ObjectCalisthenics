using System;
using System.Collections.Generic;

namespace ObjectCalisthenics._04_FirstClassCollections
{
    public class ClientDictionary
    {
        private readonly Dictionary<Guid, Client> _clients = new();

        public void Create(Client client)
        {
            //Some logic
            _clients.Add(client.Id, client);
        }

        public Client GetById(Guid id)
        {
            //Some logic
            return _clients.GetValueOrDefault(id);
        }

        public void UpdateById(Client client)
        {
            //Some logic
            _clients[client.Id] = (client);
        }

        public void DeleteById(Guid id)
        {
            //Some logic
            _clients.Remove(id);
        }
    }
}
