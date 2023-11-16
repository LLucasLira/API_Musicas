using System.Security.Cryptography;
using System.Text.Json.Serialization;

namespace ModeloMusica.Modelos
{
    internal class Musica
    {
        [JsonPropertyName("key")]
        public int? id { get; set; }

        [JsonPropertyName("song")]
        public string? rMusica { get; set; }

        [JsonPropertyName("artist")]
        public string? rArtista { get; set; }

        [JsonPropertyName("duration_ms")]
        public float dDuracao { get; set; }

        [JsonPropertyName("genre")]
        public string? rGene { get; set; }

        private string[] tonalidades = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };

        public string Tonalidade
        {
            get
            {
                return tonalidades[(int)id!];
            }
        }

        public void DetalhesMusicas(int _contador)
        {
            using(HttpClient httpClient = new HttpClient())
            {                
                Console.WriteLine(_contador + " - Artista: " + rArtista + " / Música: " + rMusica +
                    " / Duração de: " + dDuracao + " / Genero: " + rGene);
            }
        }

        public void ExibirDetalhesDaMusica()
        {
            Console.WriteLine($"Artista: {rArtista}");
            Console.WriteLine($"Música: {rMusica}");
            Console.WriteLine($"Duração em segundos: {dDuracao / 1000}");
            Console.WriteLine($"Gênero musical: {rGene}");
            Console.WriteLine($"Tonalidade: {Tonalidade}");
        }
    }
}
