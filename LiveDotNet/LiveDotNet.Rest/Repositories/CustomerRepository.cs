using LiveDotNet.Rest.Domain.Etites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace LiveDotNet.Rest.Repositories
{
    public class CustomerRepository
    {
        public IEnumerable<Customer> GetAll()      //é um tipo primitivo sempre opte por usalo pois torna nem necessaria o uso do garbageCOlector torna maus facil o alocamento na memoria.
        {
        }


        public void Save(Customer customer)
        {

        }
    }
}