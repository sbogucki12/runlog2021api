using System;
using System.Diagnostics.CodeAnalysis;

namespace runlog2021api.Models
{
    public class Run
    {
        string _type;
        string _surface;

        [AllowNull]
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long RunId { get; set; }
        [AllowNull]
        public DateTime Date { get; set; }
        [AllowNull]
        public TimeSpan Duration { get; set; }
        [AllowNull]
        public int RunKey { get; set; }
        [AllowNull]
        public string ImageUrl { get; set; }
        [AllowNull]
        public double Length { get; set; }
        [AllowNull]
        public string Type
        {
            get
            {
                return _type;
            }

            set
            {
                if (value == "outdoor" || value == "indoor")
                {
                    _type = value;
                }

                else
                {
                    throw new Exception("Not a valid Run Type.");
                }
            }
        }
        [AllowNull]
        public string Surface
        {
            get
            {
                return _surface;
            }

            set
            {
                if (value == null || value == "beach" || value == "street" || value == "trail" || value == "treadmill" || value == "outdoor" || value == "indoor")
                {
                    _surface = value;
                }
                else
                {
                    throw new Exception(value + "is not a valid Surface type.");
                }
            }
        }
        [AllowNull]
        public TimeSpan Pace
        {
            get
            {
                return Duration / Length;
            }

            set
            {
                _ = Duration / Length;
            }
        }
    }
}
