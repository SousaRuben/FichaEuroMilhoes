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
            load();
        }

        // Cria e diciona uma chave a lista
        public Chave addChave()
        {
            Chave chave = new Chave();
            chaves.Add(chave);
            return chave;
        }

        // Pesquisa chaves com base numa data
        public List<Chave> search(string data)
        {
            return chaves.FindAll(chave => chave.Data == data);
        }

        // Carrega os dados do arquivo para a memória
        public void load()
        {
            try
            {
                string jsonString = File.ReadAllText(FilePath);
                chaves = JsonSerializer.Deserialize<List<Chave>>(jsonString);
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e);
                throw e;
            }
        }

        // Armazena os dados da lista para um arquivo JSON
        public void save()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
            };

            string jsonString = JsonSerializer.Serialize(chaves, options);
            File.WriteAllText(FilePath, jsonString);
        }
    }
}
