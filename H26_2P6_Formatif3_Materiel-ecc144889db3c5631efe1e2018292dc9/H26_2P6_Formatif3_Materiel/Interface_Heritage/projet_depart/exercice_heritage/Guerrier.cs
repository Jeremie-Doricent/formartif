using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice_heritage
{
    public class Guerrier : Personnage
    {
        private int m_force;
        public int force {  get { return m_force; }}

        public override int atatquer()
        {
            return m_force*2;
        }
       public  Guerrier(string nom, int PointDvie,int force):base(nom,PointDvie)
        {
            m_force = force;
        }
        public override string Etat()
        {
            return $"{m_force}";
        }
    }
}
