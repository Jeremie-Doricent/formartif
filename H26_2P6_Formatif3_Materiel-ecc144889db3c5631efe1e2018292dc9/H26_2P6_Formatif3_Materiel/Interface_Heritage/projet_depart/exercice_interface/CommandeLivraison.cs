using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice_interface
{
    internal class CommandeLivraison : IFacturable
    {
        private double m_fraieLivraison;
        private string m_identifiant;
        private double m_prixParArticle;



        public string identifiant { get { return m_identifiant; } set { m_identifiant = value; } }
      public  double CalculerCout(int quantiter)
        {
            if(quantiter >5)
            {
                return quantiter * m_prixParArticle;
            }
            return (quantiter* m_prixParArticle)+ m_fraieLivraison;
        }

        public string ImprimerFacture(int Acticles)
        {
            return $"{identifiant}-{Acticles}=>{CalculerCout(Acticles)}";
        }
    
        public CommandeLivraison(string identifaint , double prixPararticle , double fraisLivraison)
        {
            identifiant = identifaint;
            m_fraieLivraison= fraisLivraison ;
            m_prixParArticle= prixPararticle ;
        }

    }
}
