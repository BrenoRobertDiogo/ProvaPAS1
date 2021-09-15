using System;

namespace models
{
    class Veiculos
    {
        // cor, marca, modelo, valor e ano de fabricação.
        public string Cor { get; set; }
        
        public string Marca { get; set; }
        
        public string Modelo { get; set; }
        
        public double Valor { get; set; }
        
        public DateTime AnoFabricacao { get; set; }
        
        public void definirValorVeiculo(double custoFixo)
        {
            this.Valor = custoFixo;
            
        }

        public Veiculos( string Cor,string  Marca, string Modelo, DateTime AnoFabricacao ) {
            this.Cor = Cor;
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.AnoFabricacao = AnoFabricacao;
        }
        
    }
}
