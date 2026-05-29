using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice_heritage
{
  public abstract class Personnage
    {

        protected string m_nom;
        protected int m_pointDeVie;

        public string Nom { get { return m_nom; } set { m_nom = value; } }
        public int PointDeVie { get { return m_pointDeVie; } set { m_pointDeVie = value; } }

        public abstract int atatquer();
        
        
        
        public virtual string Etat()
        {
            return$"{Nom},{PointDeVie}";
        }
        public   Personnage(string nom, int pointdevie) { 
        Nom = nom ;
            PointDeVie = pointdevie ;
        
        }
    }
}
