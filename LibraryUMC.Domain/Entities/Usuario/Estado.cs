using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryUMC.Domain.Entities.User;

namespace LibraryUMC.Domain.Entities.Usuario;

public class Estado
{
    public int Id { get; set; }
    public string Sigla { get; set; }
    public string Nome { get; set; }
    public ICollection<Municipio> Municipios { get; set; }
}

