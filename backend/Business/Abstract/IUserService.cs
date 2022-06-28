using Core.Business.Abstract;
using Core.Entites.Concrete;
using Core.Utilites.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService : IEntityService<User>
    {
        IDataResult<User> GetByEmail(string email);
        IDataResult<User> GetByUserName(string userName);
    }
}
