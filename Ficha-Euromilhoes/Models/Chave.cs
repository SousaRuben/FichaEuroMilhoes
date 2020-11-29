using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        private Random random;

        // Retorna uma string com os principais
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

        // Retorna uma string com as estrelas
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
            // Pega um valor com base no tempo
            int seed = (int) DateTimeOffset.Now.Ticks % DateTimeOffset.Now.Millisecond;
            Debug.WriteLine(seed);
            // Cria um objeto Random com base na seed
            random = new Random(seed);
            gerarPrincipais();
            gerarEstrelas();
        }

        // Gera um numero principal unico e aleatorio
        public int gerarPrincipal()
        {
            int numero = random.Next(MIN, MAX_PRINCIPAL);
            numero = principais.Contains(numero) ? gerarPrincipal() : numero;
            return numero;
        }

        // Gera uma chave unica e aleatoria
        public int gerarEstrela()
        {
            int novaEstrela = random.Next(MIN, MAX_ESTRELAS);
            novaEstrela = estrelas.Contains(novaEstrela) ? gerarEstrela() : novaEstrela;
            return novaEstrela;
        }

        // Preenche o vetor com os numeros principais
        public void gerarPrincipais()
        {
            for (int i = 0; i < principais.Length; i++)
            {
                principais[i] = gerarPrincipal();
            }
        }

        // Preenche o vetor com as estrelas da sorte
         public void gerarEstrelas()
        {
            for (int i = 0; i < estrelas.Length; i++)
            {
                estrelas[i] = gerarEstrela();
            }
        }
    }
}
