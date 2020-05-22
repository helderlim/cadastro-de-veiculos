using System;
using System.Collections.Generic;
using System.Text;

namespace Veiculos
{
    class Caminhao : Veiculos
    {
        private int numero_eixos;
        private double peso;
        private string carreta;

        public Caminhao() : base()
        {
            numero_eixos = 0;
            peso = 0.0;
            carreta = null;
        }

        public Caminhao(string modelo, string fabricante, string placa, int ano, string cor, int portas, int numero_eixos, double peso, string carreta)
            : base(modelo,fabricante,placa,ano,cor,portas)
        {
            this.numero_eixos = numero_eixos;
            this.peso = peso;
            this.carreta=carreta;
        }
        public int Numero_eixos
        {
            get { return numero_eixos; }
            set { numero_eixos = value; }
        }

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        public string Carreta
        {
            get { return carreta; }
            set { carreta = value; }
        }
    }
}
