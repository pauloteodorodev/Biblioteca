using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryUMC.Domain.Entities.Usuario;

namespace LibraryUMC.Domain.Entities.User;

public class Municipio
{
    public int Id { get; set; }
    public string Sigla { get; set; }
    public string Nome { get; set; }

    public Estado Estado { get; set; }
}

