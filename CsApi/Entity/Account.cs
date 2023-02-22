namespace CsApi.Entity
{
    public class Account
    {
        public int Aid { get; set; }
        public int Atype { get; set; } = 1;
        public string Aaccount { get; set; }
        public Decimal Abalance { get; set; }
        public int Aactive { get; set; }
        public string Averify { get; set; }
        public string Anickname { get; set; }
        public int uid { get; set; }
        public int statuss { get; set; }
        public string message { get; set; }

        
    }
}
