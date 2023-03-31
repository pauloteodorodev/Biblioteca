using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryUMC.Domain.Entities.Compartilhada;

public class Pessoa : EntidadeBase
{
    public string Nome { get; set; }
    public string CPF { get; set; }
}

