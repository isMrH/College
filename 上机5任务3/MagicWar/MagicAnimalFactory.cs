using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagicWar
{
    class MagicAnimalFactory
    {
        public static MagicAnimal CreateMagicAnimal(int n)
        {
            MagicAnimal mAnimal = null;
            switch (n)
            {
                case 1:
                    mAnimal = new People("人族", "火器", 30);
                    break;
                case 2:
                    mAnimal = new Eidolon("精灵族", "弓箭", true);
                    break;
            }
            return mAnimal;
        }

    }
}
