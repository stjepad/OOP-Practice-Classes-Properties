using Characters;
using Characters.Warriors;
using ConsoleApp1.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Characters.Spellcasters
{
    public interface ISpellcaster
    {
        Spell MySpell
        {
            get;
            set;
        }
         int Mana
        {
            get;
            set;
        }

        void CastSpell(Character character);
    }
}
