using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Income
    {
        public Guid id { get; set; }
        public decimal amount { get; set; }
        public DateTime ctime { get; set; }
        public int state { get; set; }
        public string modifier { get; set; }
        public DateTime? utime { get; set; }
        public DateTime? etime { get; set; }
    }
}
