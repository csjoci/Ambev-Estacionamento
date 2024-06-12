namespace Modulo1.Console.Entidades
{
    using System;
    internal class Veiculo
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public string? Modelo { get; set; }
        public string? Marca { get; set; }
        //public TipoVeiculo TipoVeiculo { get; set; }
        public string? Cor { get; set; }

        public virtual void MostrarDetalhes()
        {
            Console.WriteLine("Placa: " + Placa + " Modelo: " + Modelo + " Cor: " + Cor);
        }

        public Veiculo(string placa, string modelo, string marca, string cor)
        {
            this.Placa = placa;
            this.Modelo = modelo;
            this.Marca = marca;
            this.Cor = cor;
        }

        public class Carro : Veiculo
        {
            public Carro(string placa, string modelo, string marca, string cor) : base(placa, modelo, marca, cor)
            {

            }
            public override void MostrarDetalhes()
            {
                Console.WriteLine("A Placa: " + Placa);
            }

        }

    }

}

