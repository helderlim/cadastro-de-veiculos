using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Reflection.PortableExecutable;
using System.Text;

namespace Veiculos
{
    abstract class Veiculos
    {
        private string modelo, fabricante, placa, cor;
        private int ano, numero_portas;



        public Veiculos()
        {
            this.modelo = null;
            this.fabricante = null;
            this.placa = null;
            this.ano = 0;
            this.cor = null;
            this.numero_portas = 0;
        }

        public Veiculos(string modelo, string fabricante, string placa, int ano, string cor, int numero_portas)
        {
            this.modelo = modelo;
            this.fabricante = fabricante;
            this.placa = placa;
            this.cor = cor;
            this.ano = ano;
            this.numero_portas = numero_portas;
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public string Fabricante
        {
            get { return fabricante; }
            set { fabricante = value; }
        }

        public string Placa
        {
            get { return fabricante; }
            set { fabricante = value; }
        }

        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }

        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }

        public int Numero_portas
        {
            get { return numero_portas; }
            set { numero_portas = value; }
        }
    }
}
