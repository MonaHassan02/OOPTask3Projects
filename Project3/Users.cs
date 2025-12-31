using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    public abstract class User
    {
        public string Name { get;  set; }

        public abstract Discount GetDiscount();
    }


    public class RegularUser : User
    {
        public RegularUser(string name)
        {
            Name = name;
        }

        public override Discount GetDiscount()
        {
            return new PercentageDiscount(5); 
        }
    }

    public class PremiumUser : User
    {
        public PremiumUser(string name)
        {
            Name = name;
        }

        public override Discount GetDiscount()
        {
            return new FlatDiscount(100);
        }
    }

    public class GuestUser : User
    {
        public GuestUser()
        {
            Name = "Guest";
        }

        public override Discount GetDiscount()
        {
            return new NoDiscount(); 
        }
    }
}
