using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer.Contract
{
    public class PacketContent
    {
        [Key]
        public int PacketContentId { get; set; }
        public int PacketId { get; set; }
        public Packets Packets { get; set; }
        public string FieldName { get; set; } 
        public string Description { get; set; } 
    }
}
