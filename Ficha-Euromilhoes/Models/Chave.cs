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
        private Random random;

        public int[] Principais { get; set; } = new int[5];
        public int[] Estrelas { get; set; } = new int[2];

        public Chave() : base()
        {
            // Pega um valor com base no tempo
            int seed = (int) DateTimeOffset.Now.Ticks % DateTimeOffset.Now.Millisecond;

            // Cria um objeto Random com base na seed
            random = new Random(seed);
            gerarPrincipais();
            gerarEstrelas();

            // Ordena de modo ascedente
            // Array.Sort(principais);
            // Array.Sort(estrelas);
        }

        // Gera um numero principal unico e aleatorio
        public int gerarPrincipal()
        {
            int numero = random.Next(MIN, MAX_PRINCIPAL);
            numero = Principais.Contains(numero) ? gerarPrincipal() : numero;
            return numero;
        }

        // Gera uma chave unica e aleatoria
        public int gerarEstrela()
        {
            int novaEstrela = random.Next(MIN, MAX_ESTRELAS);
            novaEstrela = Estrelas.Contains(novaEstrela) ? gerarEstrela() : novaEstrela;
            return novaEstrela;
        }

        // Preenche o vetor com os numeros principais
        public void gerarPrincipais()
        {
            for (int i = 0; i < Principais.Length; i++)
            {
                Principais[i] = gerarPrincipal();
            }
        }

        // Preenche o vetor com as estrelas da sorte
        public void gerarEstrelas()
        {
            for (int i = 0; i < Estrelas.Length; i++)
            {
                Estrelas[i] = gerarEstrela();
            }
        }

        // Retorna uma string com os principais
        public string PrincipalString()
        {
            string data = "";
            foreach (int valor in Principais)
            {
                data += $"{valor} ";
            }
            return data;
        }

        // Retorna uma string com as estrelas
        public string EstrelaString()
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
