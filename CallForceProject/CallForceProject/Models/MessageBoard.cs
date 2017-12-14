using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CallForceProject.Models
{
    [Table("MessageBoard")]
    public class MessageBoard
    {
        [Key]
        public int messageID { get; set; }
        public String question { get; set; }
        public String answer { get; set; }
        public int? empID { get; set; }
        public int? userID { get; set; }
    }
}