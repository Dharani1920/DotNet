using System.ComponentModel.DataAnnotations;

namespace TrainingApi
{
    public class Employees
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; } = string.Empty;
        public double Experience { get; set; }
    }

    public class EmployeeWF
    {
        [Key]
        public int EmpId { get; set; }
        public string EmpName { get; set; } = string.Empty;
        public double Experience { get; set; }
    }

    public class EmployeePositionWF
    {
        [Key]
        public int EmpId { get; set; }
        public string Position { get; set; } = string.Empty;
        public string Project { get; set; } = string.Empty;
    }
}
