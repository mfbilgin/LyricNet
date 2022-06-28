using Core.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entites.Concrete
{
    public class Song : IEntity
    {
        public int SongId { get; set; }
        public int UserId { get; set; }
        public string SongName { get; set; }
        public string SongLink { get; set; }
        public string Lyrics { get; set; }
        public DateTime RegistrationDate { get; set; }

    }
}
