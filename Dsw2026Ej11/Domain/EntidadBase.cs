using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej11.Domain
{
    public abstract class EntidadBase
    {
        public int Id { get; }
        public EntidadBase()
        {
            Id = new Random().Next();
        }
        public EntidadBase(int id)
        {
            Id = id;
        }

    }
}
