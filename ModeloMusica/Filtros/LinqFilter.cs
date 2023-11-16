using System.Linq;
using ModeloMusica.Modelos;

namespace ModeloMusica.Filtros
{
    internal class LinqFilter
    {
        public static void DistinctGeneros(List<Musica> _lstMusica)
        {
            var oGenerosMusicais = _lstMusica.Select
                (rGenero => rGenero.rGene).Distinct().ToList();

            oGenerosMusicais.Sort();

            foreach (var rGenero in oGenerosMusicais)
            {
                Console.WriteLine("Gênero: " + rGenero);
            }
        }

        public static void DistinctArtistas(List<Musica> _lstMusica)
        {
            var oArtistasMusicais = _lstMusica.Select
                (artista => artista.rArtista).Distinct().ToList();

            oArtistasMusicais.Sort();

            foreach (var artista in oArtistasMusicais)
            {
                Console.WriteLine("Arista: " + artista);
            }
        }

        public static void FiltrarArtistaConformeGenero(List<Musica> _lstMusica, string _genero)
        {
            var oArtistasConformeGenero = _lstMusica.Where
                (musica => musica.rGene!.Contains(_genero)).Select
                (musica => musica.rArtista).Distinct().ToList();

            foreach (var artist in oArtistasConformeGenero)
            {
                Console.WriteLine("Artista: " + artist + " do gênero: " + _genero);
            }
        }

        public static void FiltrarMusicasConformeArtista(List<Musica> _lstMusica, string _artista)
        {
            var oMusicaConformeArtista = _lstMusica.Where
                (musica => musica.rArtista!.Equals(_artista)).Select
                (musica => musica.rMusica).Distinct().ToList();

            foreach (var musica in oMusicaConformeArtista)
            {
                Console.WriteLine("Musica: " + musica + " do artista: " + _artista);
            }
        }

        public static void FiltrarDeAcordoComTonalidade(List<Musica> _lstMusicas, string _tonalidade)
        {
            var oListaMusicasDeAcordoComTonalidade = _lstMusicas
                .Where(musica => musica.Tonalidade.Equals(_tonalidade))
                .Select(musica => musica.rMusica)
                .ToList();
            foreach (var musicas in oListaMusicasDeAcordoComTonalidade)
            {
                Console.WriteLine($"Musica: {musicas}");
            }
        }
    }
}
