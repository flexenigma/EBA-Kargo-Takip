namespace EBA_Kargo_Takip
{
    public class Gonderi
    {
        public int Id { get; set; }
        public string TakipNo { get; set; }
        public string Durum { get; set; }

        public Gonderi()
        {
            Id = 0;
            TakipNo = string.Empty;
            Durum = string.Empty;
        }

        public override string ToString()
        {
            return $"Gonderi Id: {Id}, Takip No: {TakipNo}, Durum: {Durum}";
        }
    }
}