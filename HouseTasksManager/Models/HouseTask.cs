using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HouseTasksManager.Models
{
    public class HouseTask
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Value { get; set; }
        public HouseTask()
        {
            
        }
    }
}
