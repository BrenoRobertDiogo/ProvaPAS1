using System;
using models;

namespace Prova1
{
    class Program
    {
        static void Main(string[] args)
        {
            var con = new Concessionaria();
            var nacional = new Veiculos(
                "Branco",// string Cor
                "Azuleijo",// string  Marca
                "Forza horizon",// string Modelo
                new DateTime(2015, 12, 25)// DateTime AnoFabricacao
            );
            var imp = new Importado(
                "Italia",
                "Pretão",// string Cor
                "Maneira",// string  Marca
                "Forza horizon",// string Modelo
                new DateTime(2015, 12, 25)// DateTime AnoFabricacao
            );
            con.AdicionarCarro(nacional);
            Console.WriteLine(imp);
        }
    }
}
