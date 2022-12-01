﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public enum TipoSexo
    {
        MASCULINO,
        FEMININO
    }

    public class Pet
    {
        public long PetId { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public TipoSexo Sexo { get; set; }
    }
}