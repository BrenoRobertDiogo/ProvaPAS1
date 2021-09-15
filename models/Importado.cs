using System;

namespace models
{
    class Importado : Veiculos
    {
        public string PaisProjetado { get; set; }
        
        
        public void definirValorVeiculo(double custoFixo) {
            this.Valor = custoFixo *3.0 + 0.6*custoFixo + custoFixo/5;
        }

        public Importado(string paisProjetado,string cor,string  marca, string modelo, DateTime anoFabricacao) : base( cor, marca, modelo, anoFabricacao ) {
            this.PaisProjetado = paisProjetado;
        }

        public string melhorCorredor(string qualPaisFoiMelhorComEsseCarro) 
        {
            return $"Melhor corredor do {qualPaisFoiMelhorComEsseCarro} com esse carro foi 'NOME QUE VEM DE ALGUMA API'";
        }

    }
}
