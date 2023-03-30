using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryUMC.Domain.Entities.Compartilhada;
using LibraryUMC.Domain.Entities.Usuario;

namespace LibraryUMC.Domain.Entities.User;

public class Usuario : EntidadeBase
{
    public virtual string Email { get; set; }
    public virtual string TelefoneFixo { get; set; }
    public virtual string TelefoneCelular { get; set; }
    public virtual bool Ativo { get; set; }

    public virtual Endereco Endereco { get; set; }
    public Pessoa Pessoa { get; set; }
    public IList<Perfil> Permissoes { get; set; } = new List<Perfil>();
    
    
}

