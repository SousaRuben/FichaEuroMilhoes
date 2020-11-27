using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_Euromilhoes.Models
{
    class Chave : Model
    {
        public const int MAX_PRINCIPAL = 51;
        public const int MAX_ESTRELAS = 13;
        public const int MIN = 1;
        public int[] Principais = new int[5];
        public int[] Estrelas = new int[2];
        Random random = new Random();

        public Chave() : base()
        {
            gerarPrincipais();
            gerarEstrelas();
        }

        public int gerarPrincipal()
        {
            int numero = random.Next(MIN, MAX_PRINCIPAL);
            numero = Principais.Contains(numero) ? gerarPrincipal() : numero;

            return numero;
        }

        public int gerarEstrela()
        {
            int novaEstrela = random.Next(MIN, MAX_ESTRELAS);
            novaEstrela = Estrelas.Contains(novaEstrela) ? gerarEstrela() : novaEstrela;

            return novaEstrela;
        }

        public void gerarPrincipais()
        {
            for (int i = 0; i < Principais.Length; i++)
            {
                Principais[i] = gerarPrincipal();
            }
        }

         public void gerarEstrelas()
        {
            for (int i = 0; i < Estrelas.Length; i++)
            {
                Estrelas[i] = gerarEstrela();
            }
        }
           
        public string getPrincipais()
        {
            string data = "";

            foreach (int valor in Principais)
            {
                data += $"{valor} ";
            }

            return data;
        }
        public string getEstrelas()
        {
            string data = "";

            foreach (int valor in Estrelas)
            {
                data += $"{valor} ";
            }

            return data;
        }

    }
}
