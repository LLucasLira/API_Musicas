
using ModeloMusica.Modelos;

namespace ModeloMusica.Filtros
{
    internal class LinqOrder
    {
        public static void ExibirArtistasOrdenados(List<Musica> _lstMusica)
        {
            var artistasOrdenados = _lstMusica.OrderBy
                (musica => musica.rArtista).Select
                (musica => musica.rArtista).Distinct().ToList();

            Console.WriteLine("Listas de artistas ordenados:");
            foreach (var artist in artistasOrdenados)
            {
                Console.WriteLine("Artista: " + artist);
            }
        }
    }
}
