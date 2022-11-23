namespace FileManagerAPI.Models
{
    public class HVI
    {        
        public decimal UHML { get; set; }
        public decimal UI { get; set; }
        public decimal STRENGTH { get; set; }
        public decimal SFI { get; set; }
        public decimal MIC { get; set; }
        public decimal COLORGRADE { get; set; }
        public decimal TRASHID { get; set; }
    }

    public class ListHVI
    {
        public List<HVI> HVIList { get; set; }
    }
}
