using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryUMC.Domain.Entities;

public abstract class EntidadeBase
{
    public Guid Id { get; private set; }

    protected EntidadeBase()
    {
        Id = Guid.NewGuid();
    }
}

