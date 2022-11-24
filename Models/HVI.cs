using Newtonsoft.Json;

namespace FileManagerAPI.Models
{
    public class HVI
    {
        //public decimal UHML { get; set; }
        //public decimal UI { get; set; }
        //public decimal STRENGTH { get; set; }
        //public decimal SFI { get; set; }
        //public decimal MIC { get; set; }
        //public decimal COLORGRADE { get; set; }
        //public decimal TRASHID { get; set; }

        [JsonProperty("UHML")]
        public decimal Uhml { get; set; }

        [JsonProperty("UI")]
        public decimal Ui { get; set; }

        [JsonProperty("STRENGTH")]
        public decimal Strength { get; set; }

        [JsonProperty("SFI")]
        public decimal Sfi { get; set; }

        [JsonProperty("MIC")]
        public decimal Mic { get; set; }

        [JsonProperty("COLORGRADE")]
        public string? Colorgrade { get; set; }

        [JsonProperty("TRASHID")]
        public decimal Trashid { get; set; }

    }

    public class ListHVI
    {
        public List<HVI> HVIList { get; set; } = new List<HVI>();
    }
}
