﻿using System.Linq.Expressions;

namespace MeusLivros.Models
{
    public abstract class Entity
    {
      
        public Guid Id { get; set; }

        protected Entity()
        {
            Id = Guid.NewGuid();
        }
    }
}
