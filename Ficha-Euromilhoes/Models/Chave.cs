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
        public Chave() : base()
        {
            gerarPrincipais();
            gerarEstrelas();
        }

        public int gerarEstrela()
        {
            Random random = new Random();
            int novaEstrela = random.Next(MIN, MAX_ESTRELAS);
            novaEstrela = Estrelas.Contains(novaEstrela) ? gerarEstrela() : novaEstrela;

            return novaEstrela;
        }

        public void gerarPrincipais()
        {
            Random random = new Random();

            for (int i = 0; i < Principais.Length; i++)
            {
                Principais[i] = random.Next(MIN, MAX_PRINCIPAL);
            }
        }
         public void gerarEstrelas()
        {
            for (int i = 0; i < Estrelas.Length; i++)
            {
                Estrelas[i] = gerarEstrela();
            }
        }
            
    }
}
