using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication7.ViewModels
{
    public class ClienteViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataHora { get; set; }
        public bool Atualizar { get; set; }
    }
}