using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiveDotNet.Rest.Domain.Etites
{
    public class Customer
    {

        public Guid Id { get; private set; } //colcoar o private antes do set para privatizar o acesso ao metodo 
        
        public string Name { get; private set; }

        public string CPF { get; private set; }

        public DateTime Created { get; private set; }

        public Customer(string name, string cpf ) //Encapsulamento
        {

                this.Name = name;
                this.CPF = cpf;
                Id = Guid.NewGuid();
                Created = DateTime.Now;

        }                                       //Encapsulamento

        public bool IsSpecial ()
        {
            return DateTime.Now.Year - Created.Year >= 5;
        }
    }
}
