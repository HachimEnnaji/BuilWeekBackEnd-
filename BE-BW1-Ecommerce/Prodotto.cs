namespace BE_BW1_Ecommerce
{
    public class Prodotto
    {
        private int _id;
        public int Id
        {
            get => _id;
            set => _id = value;
        }
        private string _titolo;
        public string Titolo
        {
            get => _titolo;
            set => _titolo = value;
        }
        private decimal _prezzo;
        public decimal Prezzo
        {
            get => _prezzo;
            set => _prezzo = value;
        }
        private string _immagine;
        public string Immagine
        {
            get => _immagine;
            set => _immagine = value;
        }



    }

}