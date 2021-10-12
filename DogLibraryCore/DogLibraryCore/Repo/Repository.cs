using System;
using System.Collections.Generic;
using System.Text;

namespace DogLibraryCore
{
    public class Repository<T> : IRepository<T> where T : EntityBase
    {
        List<T> _repo;

        public Repository()
        {
            _repo = new List<T>();
        }
        public virtual T GetById(int id)
        {
            return _repo.Find(e => e.Id == id);
        }
        public virtual IEnumerable<T> List()
        {
            return _repo;
        }

        public void Add(T entity)
        {
            _repo.Add(entity);

        }
        public void Remove(T entity)
        {
            _repo.Add(entity);

        }
        public void Update(T entity)
        {

        }
    }
}
