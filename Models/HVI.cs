namespace FileManagerAPI.Models
{
    public class HVI
    {
        public decimal Uhml { get; set; }
        public decimal Ui { get; set; }
        public decimal Strength { get; set; }
        public decimal Sfi { get; set; }
        public decimal Mic { get; set; }
        public decimal Colorgrade { get; set; }
        public decimal Trashid { get; set; }
    }

    public class ListHVI
    {
        public List<HVI> HVIList { get; set; } = new List<HVI>();
    }
}
