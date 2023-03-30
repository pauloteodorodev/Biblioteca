using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryUMC.Domain.Entities.Book;

public class Livro
{
    public int Id { get; set; }
    public string ISBN { get; set; }
    public DateTime DataPublicação { get; set; }
    public ICollection<Genero> Generos { get; set; }
    public  int Quantidade { get; set; }
}

