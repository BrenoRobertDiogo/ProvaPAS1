using System;
using System.Collections.Generic;

namespace models
{
    class Concessionaria
    {
        // localização, gerente principal, ano de fundação e carros disponíveis.
        protected string Localizacao { get; set; }
        
        protected string GerentePrincipal { get; set; }
        
        protected DateTime AnoFabricacao { get; set; }
        
        protected List<Veiculos> CarrosDisponiveis = new List<Veiculos>();
        

        public void AdicionarCarro (Veiculos x) 
        {
            this.CarrosDisponiveis.Add(x);
        }

        public double CalcularPortfolio () 
        {
            double retornar = 0;
            foreach(Veiculos v in this.CarrosDisponiveis)
            {
                retornar += v.Valor;
            }
            return retornar;
        }
    }
}
