using DogLibrary;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DogLibraryCore
{
    
    //persistance
    public class MammalRepoSimple
    {
        List<IMammal> Mammals; 

        public MammalRepoSimple()
        {
            Mammals = new List<IMammal>();
        }

        public virtual void Add(IMammal mammal)
        {
            this.Mammals.Add(mammal);
        }

        public virtual void Remove(IMammal mammal)
        {
            this.Mammals.Remove(mammal);
        }

        public virtual IMammal GetMammalByName(string Name)
        {
            //non linq
            foreach (var item in Mammals)
            {
                if(item.Name == Name)
                {
                    return item;
                }
            }

            //null object pattern
            return null;
        }

        public IMammal GetMammalByWeight(int findWeight)
        {
            
            return this.Mammals.Where(m => m.Weight == findWeight).FirstOrDefault();
        }
    }
}
