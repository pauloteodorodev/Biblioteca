﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryUMC.Domain.Entities.Usuario;

namespace LibraryUMC.Domain.Entities.User;

public class Endereco
{
    public int Id { get; set; }
    public string Rua { get; set; }
    public string Numero { get; set; }
    public string Complemento { get; set; }
    public string CEP { get; set; }
    public Estado Estado { get; set; }
    public Municipio Municipio { get; set; }
}

