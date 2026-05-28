using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice_interface
{
    public class SessionJeu : IFacturable
    {
        private bool m_estAbonne;
        private string m_identifiant;
        private double m_tarifhoraire;


        public string identifiant { get { return m_identifiant; } set { m_identifiant = value; } }
        public double CalculerCout(int heure)
        {
            if (m_estAbonne)
            {
                return heure * m_tarifhoraire * 0.80;
            }
            else {

                return heure * m_tarifhoraire;
            }
        }
      
        public string ImprimerFacture(int Acticles)
        {
            string bonne = m_estAbonne ? "Abonner" : " standard";
            return $"{identifiant}-{bonne}-{Acticles}-{CalculerCout(Acticles)}";
        }

      public  SessionJeu( string identifiant1 , double tarishoraire, bool estAbonner )
        {
            identifiant = identifiant1;
            m_tarifhoraire = tarishoraire;
            m_estAbonne = estAbonner;
        }
    }
}
