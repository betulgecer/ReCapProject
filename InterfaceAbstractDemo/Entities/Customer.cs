using InterfaceAbstractDemo.Abstract;
using System;

namespace InterfaceAbstractDemo.Entities
{
        public class Customer : IEntity
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime DateOfBirth { get; set; } //doğum tarihi
            public string NationalityId { get; set; } //tc nosu
        }
}

