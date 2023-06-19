using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    [Table("WEIGHT_HEADER")]
    public class Weight_Header
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_WEIGHT_HEADER { get; set; }
        public int DRY_OPERATING_WEIGHT { get; set; }
            public string DRY_OPERATING_WEIGHT_UNIT { get; set; }
            public int LOAD { get; set; }
            public string LOAD_UNIT { get; set; }
            public int ZERO_FUEL_WEIGHT_EW { get; set; }
            public int ZERO_FUEL_WEIGHT_SL { get; set; }
            public int TAKEOFF_EW { get; set; }
            public int TAKEOFF_OL { get; set; }
            public int TAKEOFF_SL { get; set; }
            public string TAKEOFF_REASON { get; set; }
            public int LANDING_EW { get; set; }
            public int LANDING_OL { get; set; }
            public int LANDING_SL { get; set; }
            public string WEIGHT_HEADER_EXTENSION { get; set; }
        }

 
}
