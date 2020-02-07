using System;
using System.Collections.Generic;

namespace SmokeTube.Models
{
    public class Pokur
    {

        public int PokurId { get; set; }
        public List<Member> Members {
            get;
            set; }
        public string NameOfTobacco { get; set; }
        public decimal PriceOfTobacco { get; set; }
        public int AmountOfTobacco { get; set; }
    }

}
