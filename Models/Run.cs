using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace runlog2021api.Models
{
    public class Run
    {
        string _type;
        string _surface; 

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long RunId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Duration { get; set; }
        public string ImageUrl { get; set; }
        public double Length { get; set; }        
        public string Type
        {
           get
           {
                return _type;
           }

            set
            {
                if(value == "outdoors" || value == "indoors")
                {
                    _type = value; 
                }

                else
                {
                    throw new Exception("Not a valid Run Type.");
                }
            }
        }
          
        public string Surface
        {            
            get
            {
                return _surface; 
            }

            set
            {
                if (value == null || value == "beach" || value == "street" || value == "trail" || value == "treadmill")
                {
                    _surface = value; 
                } 
                else
                {
                    throw new Exception("Not a valid Surface type.");
                }
            }
        }
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
