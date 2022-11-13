using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyExample.Strategies
{
    internal class Broom: IWeapon
    {
        void IWeapon.Shoot()
        {
            Console.WriteLine("Снова нападает веником");
        }
        
    }
}
