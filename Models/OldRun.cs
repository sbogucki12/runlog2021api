namespace runlog2021api.Models
{
    public class OldRun
    {
        string _comment;
        public object _id { get; set; }
        public string Comment
        {
            get
            {
                return _comment;
            }
            set
            {
                _comment = value.ToString();
            }
        }
        public double Distance { get; set; }
        public double Duration { get; set; }
        public string Date { get; set; }
        public int Key { get; set; }
    }
}
