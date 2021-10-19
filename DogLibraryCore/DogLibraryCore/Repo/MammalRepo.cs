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

        public void Add(IMammal entity)
        {
            this._repo.Add(entity);
        }

        public IMammal GetById(int id)
        {
            return this._repo.Where<IMammal>(m => m.Id == id).FirstOrDefault();
        }

        public IEnumerable<IMammal> List()
        {
            return this._repo;
        }

        void Remove(IMammal entity)
        {
            this._repo.Remove(entity); 
        }

        public IMammal GetMammalByName(string findName)
        {
            return this._repo.Where(m => m.Name == findName).FirstOrDefault();
        }

        public IMammal GetMammalByWeight(int findWeight)
        {
            return this._repo.Where(m => m.Weight == findWeight).FirstOrDefault();
        }
    }
}
