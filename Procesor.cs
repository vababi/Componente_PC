using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Componente_PC
{
    internal class Procesor
    {
        public string CodProcesor { get;set; }
        public string NumeProcesor { get;set;}
        public int NrNucleuProcesor { get;set; } 
        public double PretProcesor { get;set; }  
        public string ProducatorProcesor { get;set; } 
    
     public Procesor()
        {

        }
     public Procesor(string codProcesor, string numeProcesor, int nrNucleuProcesor, double pretProcesor, string producatorProcesor)
        {
            CodProcesor = codProcesor;
            NumeProcesor = numeProcesor;
            NrNucleuProcesor = nrNucleuProcesor;
            PretProcesor = pretProcesor;
            ProducatorProcesor = producatorProcesor;
        }
    }
}
