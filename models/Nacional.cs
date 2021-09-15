using System;

namespace models
{
    class Nacional : Veiculos
    {
        public void definirValorVeiculo(double custoFixo) {
            this.Valor = custoFixo * 1.5 + 0.2*custoFixo + custoFixo/10;
        }

        public Nacional(string cor,string  marca, string modelo, DateTime anoFabricacao) : base( cor, marca, modelo, anoFabricacao ) { }

        public string melhorCorredor() 
        {
            return "Melhor corredor do Brasil com esse carro foi Ayrton Senna";
        }
    }
}
