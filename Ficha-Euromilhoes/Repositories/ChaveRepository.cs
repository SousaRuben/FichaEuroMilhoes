using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

using Ficha_Euromilhoes.Models;
namespace Ficha_Euromilhoes.Repositories
{
    class ChaveRepository
    {
        public string FilePath { get; }
        public List<Chave> chaves = new List<Chave>();

        public ChaveRepository(string path)
        {
            FilePath = path;
        }

        // Cria e diciona uma chave a lista
        public Chave addChave()
        {
            Chave chave = new Chave();
            chaves.Add(chave);
            return chave;
        }

        // Armazena os dados da lista para um arquivo JSON
        public void save()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
            };

            string jsonSting = JsonSerializer.Serialize(chaves, options);
            File.WriteAllText(FilePath, jsonSting);
        }
    }
}
