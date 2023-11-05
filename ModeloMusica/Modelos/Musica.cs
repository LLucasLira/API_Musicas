using System.Text.Json.Serialization;

namespace ModeloMusica.Modelos
{
    internal class Musica
    {
        [JsonPropertyName("song")]
        public string? rMusica { get; set; }

        [JsonPropertyName("artist")]
        public string? rArtista { get; set; }

        [JsonPropertyName("duration_ms")]
        public float dDuracao { get; set; }

        [JsonPropertyName("genre")]
        public string? rGene { get; set; }

        public void DetalhesMusicas(int _contador)
        {
            using(HttpClient httpClient = new HttpClient())
            {                
                Console.WriteLine(_contador + " - Artista: " + rArtista + " / Música: " + rMusica +
                    " / Duração de: " + dDuracao + " / Genero: " + rGene);
            }
        }
    }
}
