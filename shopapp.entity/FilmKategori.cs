namespace shopapp.entity
{
    public class FilmKategori
    {
        public int FilmId { get; set; }
        public Film Film { get; set; }

        public int KategoriId { get; set; }
        public Kategori Kategori { get; set; }
    }
}