using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice_interface
{
    public interface IFacturable
    {

      public  string identifiant { get; }
        double CalculerCout(int n);
        string ImprimerFacture(int n);
    }
}
