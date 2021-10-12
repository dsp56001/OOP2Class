﻿using DogLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace DogLibraryCore
{
    public class MammalRepoSimple
    {
        List<IMammal> Mammals;

        public MammalRepoSimple()
        {
            Mammals = new List<IMammal>();
        }

        public virtual void AddMammal(IMammal mammal)
        {
            this.Mammals.Add(mammal);
        }

        public virtual void RemoveMammal(IMammal mammal)
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

    }
}
