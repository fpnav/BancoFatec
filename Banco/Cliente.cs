using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banco
{
    public class Cliente
    {
        
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public Conta Conta { get; set; }
    }
}
