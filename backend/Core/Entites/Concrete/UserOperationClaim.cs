using Core.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entites.Concrete
{
    public class UserOperationClaim : IEntity
    {
        public int UserOperationClaimId { get; set; }
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }
    }
}
