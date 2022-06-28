using Core.Entites.Abstract;
using Core.Utilites.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Business.Abstract
{
    public interface IEntityService<T> where T : class,IEntity,new()
    {
        IDataResult<T> GetById(int entityId);
        IResult Update(T entity);
        IResult Delete(T entity);
        IDataResult<List<T>> GetAll();
        IDataResult<T> Add(T entity);   
    }
}
