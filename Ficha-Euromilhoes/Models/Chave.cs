using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_Euromilhoes.Models
{
    class Chave : Model
    {
        private const int MAX_PRINCIPAL = 51;
        private const int MAX_ESTRELAS = 13;
        private const int MIN = 1;
        private int[] principais = new int[5];
        private int[] estrelas = new int[2];
        private Random random = new Random();

        public string Principais
        {
            get
            {
                string data = "";
                foreach (int valor in principais)
                {
                    data += $"{valor} ";
                }
                return data;
            }
        }

        public string Estrelas
        {
            get
            {
                string data = "";
                foreach (int valor in estrelas)
                {
                    data += $"{valor} ";
                }
                return data;
            }
        }


        public Chave() : base()
        {
            gerarPrincipais();
            gerarEstrelas();
        }

        public int gerarPrincipal()
        {
            int numero = random.Next(MIN, MAX_PRINCIPAL);
            numero = principais.Contains(numero) ? gerarPrincipal() : numero;

            return numero;
        }

        public int gerarEstrela()
        {
            int novaEstrela = random.Next(MIN, MAX_ESTRELAS);
            novaEstrela = estrelas.Contains(novaEstrela) ? gerarEstrela() : novaEstrela;

            return novaEstrela;
        }

        public void gerarPrincipais()
        {
            for (int i = 0; i < principais.Length; i++)
            {
                principais[i] = gerarPrincipal();
            }
        }

         public void gerarEstrelas()
        {
            for (int i = 0; i < estrelas.Length; i++)
            {
                estrelas[i] = gerarEstrela();
            }
        }
    }
}
