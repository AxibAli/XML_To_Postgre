using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    [Table("AIRPORT_DATALIST")]
    public class Airport_Datalist
    {
         
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int ID_AIRPORT_DATALIST { get; set; }

            public string FUNCTION { get; set; }
            public string NAME { get; set; }
            public string ICAO_CODE { get; set; }
            public string IATA_CODE { get; set; }
            public string PLANNED_RUNWAY { get; set; }
            public DateTimeOffset SUITABLE_PER_FROM { get; set; }
            public DateTimeOffset SUITABLE_PER_UNTIL { get; set; }
            public int REQ_HOR_VISIBILITY { get; set; }
            public int REQ_VER_VISIBILITY { get; set; }
            public int CON_HOR_VISIBILITY { get; set; }
            public int CON_VER_VISIBILITY { get; set; }
       

    }
}
