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

            foreach(var artist in oArtistasConformeGenero)
            {
                Console.WriteLine("Artista: " + artist + " do gênero: " + _genero);
            }
        }


    }
}
