// See https://aka.ms/new-console-template for more information


//linq queries
//string[] names = { "Dharani", "Mehak", "Akshay" };

//var linqQuery = from name in names
//               where name.Contains("a")
//               select name;

//foreach (var item in linqQuery)
//{

//    Console.WriteLine($"name which contains a: {item}");
//}

using DotNet;

EmpDetailDb empDetails = new EmpDetailDb();

var emp = empDetails.GetEmployeeDetails(100);

foreach (var item in emp)
{
    //if (item.EmpName == "Dharani")
    //{
    //    Console.WriteLine($"Employee id: {item.EmpId} \n Experience: {item.Experience}");
    //}
    Console.WriteLine($"Employee name: {item.EmpName} --> Experience: {item.Experience}");
}

Employees EmpDetails = new Employees();

EmpDetails.EmpId = 100;
EmpDetails.EmpName = "Dharani";
EmpDetails.Experience = 2.1;

//bool addResult = empDetails.addEmployeeDetails(EmpDetails);

//bool deleteResult = empDetails.deleteEmployeeDetails(101);

bool updateResult = empDetails.updateEmployeeDetails(100);

