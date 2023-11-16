using System.Text.Json;
using ModeloMusica.Modelos;
using ModeloMusica.Filtros;
using System.Security.Cryptography.X509Certificates;

try
{
    using (HttpClient client = new HttpClient())
    {
        using (HttpClient httpclient = new HttpClient())
        {
            string resposta;
            string strArtistaEscolhido;
            string strEstiloMusicalEscolhido;

            resposta = await httpclient.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

            var lstMusica = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

            //1. EXIBIR DETALHES DE TODAS AS MUSICAS
            //for (int i = 0; i < lstMusica.Count; i++)
            //{
            //    lstMusica[i].DetalhesMusicas(i);
            //}

            //2. GENEROS DISTINTOS
            //LinqFilter.DistinctGeneros(lstMusica);

            //3. ARTISTAS DISTINTOS
            //LinqFilter.DistinctArtistas(lstMusica);

            //4. ORDENAR E EXIBIR ARTISTAS
            //LinqOrder.ExibirArtistasOrdenados(lstMusica);

            //5. FILTRAR ARTISTA DE ACORDO COM O ESTILO MUSICAL ESCOLHIDO
            //LinqFilter.DistinctGeneros(lstMusica);
            //MensagemConsole();
            //strEstiloMusicalEscolhido = Console.ReadLine()!;
            //LinqFilter.FiltrarArtistaConformeGenero(lstMusica, strEstiloMusicalEscolhido);

            //6. FILTRAR MUSICAS DE ACORDO COM A MUSICA ESCOLHIDA
            //LinqFilter.DistinctArtistas(lstMusica);
            //MensagemConsole();
            //strArtistaEscolhido = Console.ReadLine()!;
            //LinqFilter.FiltrarMusicasConformeArtista(lstMusica, strArtistaEscolhido);

            //7. MUSICAS PREFERIDAS
            MusicasPreferidas musicasPreferidas;
            musicasPreferidas = new MusicasPreferidas("Lira");

            musicasPreferidas.addMusicasFavoritas(lstMusica[2]);
            musicasPreferidas.addMusicasFavoritas(lstMusica[71]);
            musicasPreferidas.addMusicasFavoritas(lstMusica[139]);
            musicasPreferidas.addMusicasFavoritas(lstMusica[583]);
            musicasPreferidas.addMusicasFavoritas(lstMusica[938]);

            musicasPreferidas.ExibirMusicasFavoritas();

            musicasPreferidas.GeraArquivoJson();

        }
    }
}
catch (Exception ex)
{
    Console.WriteLine("Erro em: " + ex.Message);
}

static void MensagemConsole()
{
    Console.WriteLine("################################################");
    Console.WriteLine("Escolha um das opções mencionadas acima:");
}
static void ObterListaDeTons(List<Musica> _lstMusica)