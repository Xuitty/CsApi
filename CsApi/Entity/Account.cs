using System.Text.Json;

namespace CsApi.Entity
{
    public class Account
    {
        public int? Aid { get; set; }
        public int? Atype { get; set; } = 1;
        public string? Aaccount { get; set; }
        public Decimal? Abalance { get; set; }
        public int? Aactive { get; set; }
        public string? Averify { get; set; }
        public string? Anickname { get; set; }
        public int? Uid { get; set; }
        public int? Statuss { get; set; }
        public string? Message { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
