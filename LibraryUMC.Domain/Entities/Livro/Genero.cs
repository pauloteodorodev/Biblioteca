using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryUMC.Domain.Entities.Book;

public class Genero
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Sigla { get; set; }
    public bool IsActive { get; set; }
}

