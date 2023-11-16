using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ModeloMusica.Modelos
{
    internal class MusicasPreferidas
    {
        public string? rNome { get; set; }
        public List<Musica> lstMusicasFavoritas { get; set; }

        public MusicasPreferidas(string _nome)
        {

            rNome = _nome;
            lstMusicasFavoritas = new List<Musica>();
        }

        public void addMusicasFavoritas(Musica _musica)
        {
            lstMusicasFavoritas.Add(_musica);
        }

        public void ExibirMusicasFavoritas()
        {
            Console.WriteLine("Essas são as músicas favoritas -> " + rNome);
            foreach (var musica in lstMusicasFavoritas)
            {
                Console.WriteLine(musica.rArtista + " - " + musica.rMusica);
            }
        }

        public void GeraArquivoJson()
        {
            try
            {

                string json = JsonSerializer.Serialize(new
                {
                    nome = rNome,
                    musicas = lstMusicasFavoritas
                });

                string nomeArquivo = $"Musicas_Favoritas_{rNome}.json";
                File.WriteAllText(nomeArquivo, json);
                string pathFile = Path.GetFullPath(nomeArquivo);
                Console.WriteLine("Arquivo salvo com sucesso no caminho: " + pathFile);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro em MusicasPreferidas - GeraArquivoJson() " + ex.Message);
            }

        }
    }
}
