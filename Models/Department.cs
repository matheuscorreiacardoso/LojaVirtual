using System;
using System.Collections.Generic;

namespace LojaVirtual.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        #region Constructor

        public Department() { }

        public Department(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        #endregion
    }
}
