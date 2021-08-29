using System;
using System.Collections.Generic;

namespace ObjectCalisthenics._04_FirstClassCollections
{
    public  class FirstClassCollections
    {
        public class ClientService 
        { 
            private readonly Dictionary<Guid, Client> _clients = new();
        
            public Client Create(string name)
            {
                //Logic

                var client = new Client();
                _clients.Add(Guid.NewGuid(), client);
                return client;
            }

            public Client GetById(Guid id)
            {
                //Logic
                return _clients.GetValueOrDefault(id);
            }
        }


        //Refactoring
        public class ClientService2
        {
            private readonly ClientDictionary _clients = new();

            public Client Create(string name)
            {
                //Logic

                var client = new Client();
                _clients.Create(client);
                return client;
            }

            public Client GetById(Guid id)
            {
                //Logic
                return _clients.GetById(id);
            }
        }
    }
}
