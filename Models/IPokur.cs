using System;
using System.Collections.Generic;
using System.Linq;


namespace SmokeTube.Models
{
    public interface IPokur
    {
        IQueryable<Pokur> Pokurs { get;}
        IQueryable<Member> Members { get; }
        void Transaction(int amount,string nameFrom,string nameTo);
        void AddPokur(Pokur pokur);
    }
}
