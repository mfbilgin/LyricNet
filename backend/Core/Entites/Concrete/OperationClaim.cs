﻿using Core.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entites.Concrete
{
    public class OperationClaim : IEntity
    {
        public int OperationClaimId { get; set; }
        public string OperationClaimName { get; set; }

    }
}
