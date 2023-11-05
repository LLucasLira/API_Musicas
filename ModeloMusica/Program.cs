using System.Text.Json;
using ModeloMusica.Modelos;

try
{
    using (HttpClient client = new HttpClient())
    {

        //1. EXIBIR TODOS AS INFORMAÇÕES
        using (HttpClient httpclient = new HttpClient())
        {
            string resposta = await httpclient.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
            var lstMusica = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
            for (int i = 0; i < lstMusica.Count; i++)
            {
                lstMusica[i].ExibirDetalhesMusica(i);
            }
        }
        //#######################################################################

        //2. EXIBIR TODOS OS GÊNEROS MUSICAIS DA LISTA;
        //using (HttpClient httpclient = new HttpClient())
        //{
        //    string resposta = await httpclient.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        //    var lstMusica = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //    for (int i = 0; i < lstMusica.Count; i++)
        //    {
        //        lstMusica[i].ExibirGeneros(i);
        //    }
        //}
        //#######################################################################

        //3. ORDERRNAR OS ARTISTAS POR NOME
        //using (HttpClient httpclient = new HttpClient())
        //{
        //    string resposta = await httpclient.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        //    List<Musica> lstMusica = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //    List<string> lstArtistaOrdenado = new List<string>();
        //    for (int i = 0; i < lstMusica.Count; i++)
        //    {
        //        lstArtistaOrdenado.Add(lstMusica[i].rArtista);
        //    }
        //   lstArtistaOrdenado.Sort();
        //}
    }
}
catch (Exception ex)
{
    Console.WriteLine("Erro em: " + ex.Message);
}