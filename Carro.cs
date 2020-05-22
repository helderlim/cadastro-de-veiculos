using System;
using System.Collections.Generic;
using System.Text;

namespace Veiculos
{
    class Carro : Veiculos
    {
        private int mala = 0;
        private Boolean bagageiro;
        private string combustivel;

        public Carro() : base()
        {
            mala = 0;
            bagageiro = false;
            combustivel = null;
        }

        public Carro(string modelo, string fabricante, string placa, int ano, string cor, int numero_portas, int mala, Boolean bagageiro, string combustivel)
            : base(modelo, fabricante, placa, ano, cor, numero_portas)
        {
            this.mala = mala;
            this.bagageiro = bagageiro;
            this.combustivel = combustivel;
        }

        public int Mala
        {
            get { return mala; }
            set { mala = value; }
        }

        public Boolean Bagageiro
        {
            get { return bagageiro; }
            set { bagageiro = value; }
        }

        public string Combustivel
        {
            get { return combustivel; }
            set { combustivel = value; }
        }


    }
}
