using DogLibrary;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DogLibraryCore.Repo
{
    public class MammalRepo : IRepository<IMammal>
    {

        List<IMammal> _repo;

        public MammalRepo() : base()
        {
            _repo = new List<IMammal>();
        }

        void IRepository<IMammal>.Add(IMammal entity)
        {
            this._repo.Add(entity);
        }

        IMammal IRepository<IMammal>.GetById(int id)
        {
            return this._repo.Where<IMammal>(m => m.Id == id).FirstOrDefault();
        }

        IEnumerable<IMammal> IRepository<IMammal>.List()
        {
            return this._repo;
        }

        void IRepository<IMammal>.Remove(IMammal entity)
        {
            this._repo.Remove(entity); 
        }

        
    }
}
