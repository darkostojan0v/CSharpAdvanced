﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Entities
{
   public abstract class BaseEntity
    {
        public int Id { get; }

        protected BaseEntity()
        {
            Id = GetNextEntityId();
        }

        protected abstract int GetNextEntityId();
    }
}
