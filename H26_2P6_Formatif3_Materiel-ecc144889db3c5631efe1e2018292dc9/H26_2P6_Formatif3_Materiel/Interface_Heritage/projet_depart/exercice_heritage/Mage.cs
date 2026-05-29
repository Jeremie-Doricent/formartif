using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice_heritage
{
   public  class Mage : Personnage
    {
        private int m_nbPotion;
        const int Puissance_Potion = 30;

       public int NbPotion {get {return m_nbPotion;}}

        
        
      public  Mage(string nom ,int pointDevie,int nbPotion) : base(nom, pointDevie)
        {
            m_nbPotion = nbPotion;
        }
        public override int atatquer()
        {
            if(NbPotion > 0)
            {
                return m_nbPotion++;
            }
            if(NbPotion == Puissance_Potion)
            {
                return Puissance_Potion;
            }
            return 0;
        }
        public override string Etat()
        {
            return $"{NbPotion}";
        }
    }

}
