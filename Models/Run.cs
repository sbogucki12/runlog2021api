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

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long RunId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Duration { get; set; }
        public double Length { get; set; }
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
