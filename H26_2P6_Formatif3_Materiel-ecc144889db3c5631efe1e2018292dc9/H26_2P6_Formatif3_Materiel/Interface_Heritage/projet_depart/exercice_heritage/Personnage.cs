using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice_heritage
{
  public class Personnage
    {

        private string m_nom;
        private int m_pointDeVie;

        public string Nom { get { return m_nom; } set { m_nom = value; } }
        public int PointDeVie { get { return m_pointDeVie; } set { m_pointDeVie = value; } }

        public int atatquer() {
        
        
        }
        public string Etat()
        {
            return$"{Nom},{PointDeVie}";
        }
     public   Personnage(string nom, int pointdevie) { 
        Nom = nom ;
            PointDeVie = pointdevie ;
        
        }
    }
}
