using Characters.Warriors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Characters.Spellcasters
{
    public interface ISpellcaster
    {
         int Mana
        {
            get;
            set;
        }

        void CastSpell(Warrior warrior);
    }
}
