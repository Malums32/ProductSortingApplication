using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ProductSortingAppWithDB.Models
{
    public class CustomerActivity
    {

        public int Id { get; set; } 
        public string CustomerName { get; set; }
        public string Activity {  get; set; }
        public DateTime Timestamp { get; set; }
        public TimeSpan Timespent { get; set; }
        public string ConnectionString { get; }
    }
}
