using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryUMC.Domain.Entities.Compartilhada;

namespace LibraryUMC.Domain.Entities.Livro;

public class Autor : Pessoa
{
    public string Biografia { get; set; }
    public string GeneroLiterario { get; set; }
    public bool IsAtive { get; set; }
}

