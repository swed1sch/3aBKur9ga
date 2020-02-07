using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace SmokeTube.Models
{
    public class PokurRepository:IPokur
    {
        private ApplicationDbContext context;

        public PokurRepository(ApplicationDbContext ctx) => context = ctx;

        public IQueryable<Pokur> Pokurs => context.Pokurs.Include(c=>c.Members);

        public IQueryable<Member> Members => context.Members;

        public void Transaction(int amount, string nameFrom,string nameTo)
        {
            
        }
        public void AddPokur(Pokur pokur)
        {
            context.Pokurs.Add(pokur);
            context.SaveChanges();
        }
    }
}
