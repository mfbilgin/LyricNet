using Business.Abstract;
using Core.Utilites.Results;
using DataAccess.Abstract;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class SongManager : ISongService
    {
        ISongDal _songDal;
        public SongManager(ISongDal songDal)
        {
            _songDal = songDal;
        }
        public IDataResult<Song> Add(Song entity)
        {
            _songDal.Add(entity);
            return new SuccessDataResult<Song>("Başarıyla eklendi.");
        }

        public IResult Delete(Song entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Song>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Song> GetById(int entityId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Song entity)
        {
            throw new NotImplementedException();
        }
    }
}
