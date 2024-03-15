using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet
{
    public class Projects: ManagerDetails
    {
        public static int ProjectId { get; set; } = 0;
        public static string ProjectName { get; set; } = "Iris";
        public static string ProjectLead { get; set; } = ManagerDetails.ManagerName;
    }
}
