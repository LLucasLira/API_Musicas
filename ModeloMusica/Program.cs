using System.Text.Json;
using ModeloMusica.Modelos;
using ModeloMusica.Filtros;

try
{
    using (HttpClient client = new HttpClient())
    {
        using (HttpClient httpclient = new HttpClient())
        {
            string resposta = await httpclient.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

            var lstMusica = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

            //EXIBIR DETALHES DE TODAS AS MUSICAS
            for (int i = 0; i < lstMusica.Count; i++)
            {
                lstMusica[i].DetalhesMusicas(i);
            }

            //GENEROS DISTINTOS
            LinqFilter.DistinctGeneros(lstMusica);

            //ARTISTAS DISTINTOS
            LinqFilter.DistinctArtistas(lstMusica);

            //ORDENAR E EXIBIR ARTISTAS
            LinqOrder.ExibirArtistasOrdenados(lstMusica);

            //FILTRAR ARTISTA DE ACORDO COM O ESTILO MUSICAL ESCOLHIDO
            LinqFilter.FiltrarArtistaConformeGenero(lstMusica, "pop");

            //FILTRAR MUSICAS DE ACORDO COM A MUSICA ESCOLHIDA
            LinqFilter.FiltrarMusicasConformeArtista(lstMusica, "Post Malone");
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine("Erro em: " + ex.Message);
}