namespace OOP02
{

    #region q1

    //public class Employee
    //{
    //    // Properties
    //    public int ID { get; set; }
    //    public string Name { get; set; }
    //    public string SecurityLevel { get; set; }
    //    public decimal Salary { get; set; }
    //    public DateTime HireDate { get; set; }
    //    public string Gender { get; set; }

    //    // Constructor
    //    public Employee(int id, string name, string securityLevel, decimal salary, DateTime hireDate, string gender)
    //    {
    //        ID = id;
    //        Name = name;
    //        SecurityLevel = securityLevel;
    //        Salary = salary;
    //        HireDate = hireDate;
    //        Gender = gender;
    //    }

    //    // Method to display employee details
    //    public void DisplayDetails()
    //    {
    //        Console.WriteLine($"ID: {ID}");
    //        Console.WriteLine($"Name: {Name}");
    //        Console.WriteLine($"Security Level: {SecurityLevel}");
    //        Console.WriteLine($"Salary: {Salary:C}");
    //        Console.WriteLine($"Hire Date: {HireDate:yyyy-MM-dd}");
    //        Console.WriteLine($"Gender: {Gender}");
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Create an Employee instance
    //        Employee employee = new Employee(
    //            id: 1,
    //            name: "Ahmed Ali",
    //            securityLevel: "High",
    //            salary: 75000.00m,
    //            hireDate: new DateTime(2020, 5, 1),
    //            gender: "Male"
    //        );

    //        // Display employee details
    //        Console.WriteLine("Employee Details:");
    //        employee.DisplayDetails();
    //    }
    //}


    #endregion

    #region q2

    //public class HiringDate
    //{
    //    // Properties
    //    public int Day { get; set; }
    //    public int Month { get; set; }
    //    public int Year { get; set; }

    //    // Constructor
    //    public HiringDate(int day, int month, int year)
    //    {
    //        Day = day;
    //        Month = month;
    //        Year = year;
    //    }

    //    // Method to display the hiring date
    //    public override string ToString()
    //    {
    //        return $"{Day:D2}/{Month:D2}/{Year}";
    //    }
    //}

    //// Define a class for Employee
    //public class Employee
    //{
    //    // Properties
    //    public int ID { get; set; }
    //    public string Name { get; set; }
    //    public string SecurityLevel { get; set; }
    //    public decimal Salary { get; set; }
    //    public HiringDate HireDate { get; set; }
    //    public string Gender { get; set; }

    //    // Constructor
    //    public Employee(int id, string name, string securityLevel, decimal salary, HiringDate hireDate, string gender)
    //    {
    //        ID = id;
    //        Name = name;
    //        SecurityLevel = securityLevel;
    //        Salary = salary;
    //        HireDate = hireDate;
    //        Gender = gender;
    //    }

    //    // Method to display employee details
    //    public void DisplayDetails()
    //    {
    //        Console.WriteLine($"ID: {ID}");
    //        Console.WriteLine($"Name: {Name}");
    //        Console.WriteLine($"Security Level: {SecurityLevel}");
    //        Console.WriteLine($"Salary: {Salary:C}");
    //        Console.WriteLine($"Hire Date: {HireDate}");
    //        Console.WriteLine($"Gender: {Gender}");
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Create a HiringDate instance
    //        HiringDate hireDate = new HiringDate(1, 5, 2020);

    //        // Create an Employee instance
    //        Employee employee = new Employee(
    //            id: 1,
    //            name: "Ahmed Ali",
    //            securityLevel: "High",
    //            salary: 75000.00m,
    //            hireDate: hireDate,
    //            gender: "Male"
    //        );

    //        // Display employee details
    //        Console.WriteLine("Employee Details:");
    //        employee.DisplayDetails();
    //    }
    //}

    #endregion

    #region q3

    //public class HiringDate
    //{
    //    // Properties
    //    public int Day { get; set; }
    //    public int Month { get; set; }
    //    public int Year { get; set; }

    //    // Constructor
    //    public HiringDate(int day, int month, int year)
    //    {
    //        Day = day;
    //        Month = month;
    //        Year = year;
    //    }

    //    // Method to display the hiring date
    //    public override string ToString()
    //    {
    //        return $"{Day:D2}/{Month:D2}/{Year}";
    //    }
    //}

    //// Define a class for Employee
    //public class Employee
    //{
    //    // Properties
    //    public int ID { get; set; }
    //    public string Name { get; set; }
    //    public string SecurityLevel { get; set; }
    //    public decimal Salary { get; set; }
    //    public HiringDate HireDate { get; set; }

    //    private string gender;
    //    public string Gender
    //    {
    //        get => gender;
    //        set
    //        {
    //            if (value == "M" || value == "F")
    //            {
    //                gender = value;
    //            }
    //            else
    //            {
    //                throw new ArgumentException("Gender must be 'M' or 'F'");
    //            }
    //        }
    //    }

    //    // Constructor
    //    public Employee(int id, string name, string securityLevel, decimal salary, HiringDate hireDate, string gender)
    //    {
    //        ID = id;
    //        Name = name;
    //        SecurityLevel = securityLevel;
    //        Salary = salary;
    //        HireDate = hireDate;
    //        Gender = gender; // Will use the property setter for validation
    //    }

    //    // Method to display employee details
    //    public void DisplayDetails()
    //    {
    //        Console.WriteLine($"ID: {ID}");
    //        Console.WriteLine($"Name: {Name}");
    //        Console.WriteLine($"Security Level: {SecurityLevel}");
    //        Console.WriteLine($"Salary: {Salary:C}");
    //        Console.WriteLine($"Hire Date: {HireDate}");
    //        Console.WriteLine($"Gender: {Gender}");
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        try
    //        {
    //            // Create a HiringDate instance
    //            HiringDate hireDate = new HiringDate(1, 5, 2020);

    //            // Create an Employee instance
    //            Employee employee = new Employee(
    //                id: 1,
    //                name: "Ahmed Ali",
    //                securityLevel: "High",
    //                salary: 75000.00m,
    //                hireDate: hireDate,
    //                gender: "M" // Valid gender
    //            );

    //            // Display employee details
    //            Console.WriteLine("Employee Details:");
    //            employee.DisplayDetails();
    //        }
    //        catch (ArgumentException ex)
    //        {
    //            Console.WriteLine(ex.Message);
    //        }
    //    }
    //}

    #endregion

    #region q4

    //public class HiringDate
    //{
    //    public int Day { get; set; }
    //    public int Month { get; set; }
    //    public int Year { get; set; }

    //    public HiringDate(int day, int month, int year)
    //    {
    //        Day = day;
    //        Month = month;
    //        Year = year;
    //    }

    //    public override string ToString()
    //    {
    //        return $"{Day:D2}/{Month:D2}/{Year}";
    //    }
    //}

    //public enum SecurityPrivileges
    //{
    //    Guest,
    //    Developer,
    //    Secretary,
    //    DBA
    //}

    //public class Employee
    //{
    //    public int ID { get; set; }
    //    public string Name { get; set; }
    //    public SecurityPrivileges SecurityLevel { get; set; }
    //    public decimal Salary { get; set; }
    //    public HiringDate HireDate { get; set; }

    //    private string gender;
    //    public string Gender
    //    {
    //        get => gender;
    //        set
    //        {
    //            if (value == "M" || value == "F")
    //            {
    //                gender = value;
    //            }
    //            else
    //            {
    //                throw new ArgumentException("Gender must be 'M' or 'F'");
    //            }
    //        }
    //    }

    //    public Employee(int id, string name, SecurityPrivileges securityLevel, decimal salary, HiringDate hireDate, string gender)
    //    {
    //        ID = id;
    //        Name = name;
    //        SecurityLevel = securityLevel;
    //        Salary = salary;
    //        HireDate = hireDate;
    //        Gender = gender; 
    //    }

    //    public void DisplayDetails()
    //    {
    //        Console.WriteLine($"ID: {ID}");
    //        Console.WriteLine($"Name: {Name}");
    //        Console.WriteLine($"Security Level: {SecurityLevel}");
    //        Console.WriteLine($"Salary: {Salary:C}");
    //        Console.WriteLine($"Hire Date: {HireDate}");
    //        Console.WriteLine($"Gender: {Gender}");
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        try
    //        {
    //            HiringDate hireDate = new HiringDate(1, 5, 2020);

    //            Employee employee = new Employee(
    //                id: 1,
    //                name: "Ahmed Ali",
    //                securityLevel: SecurityPrivileges.Developer,
    //                salary: 75000.00m,
    //                hireDate: hireDate,
    //                gender: "M"
    //            );

    //            Console.WriteLine("Employee Details:");
    //            employee.DisplayDetails();
    //        }
    //        catch (ArgumentException ex)
    //        {
    //            Console.WriteLine(ex.Message);
    //        }
    //    }
    //}


    #endregion

    #region q5

    //public class HiringDate
    //{
    //    public int Day { get; set; }
    //    public int Month { get; set; }
    //    public int Year { get; set; }

    //    public HiringDate(int day, int month, int year)
    //    {
    //        Day = day;
    //        Month = month;
    //        Year = year;
    //    }

    //    public override string ToString()
    //    {
    //        return $"{Day:D2}/{Month:D2}/{Year}";
    //    }
    //}

    //public enum SecurityPrivileges
    //{
    //    Guest,
    //    Developer,
    //    Secretary,
    //    DBA
    //}

    //public class Employee
    //{
    //    public int ID { get; set; }
    //    public string Name { get; set; }
    //    public SecurityPrivileges SecurityLevel { get; set; }
    //    public decimal Salary { get; set; }
    //    public HiringDate HireDate { get; set; }

    //    private string gender;
    //    public string Gender
    //    {
    //        get => gender;
    //        set
    //        {
    //            if (value == "M" || value == "F")
    //            {
    //                gender = value;
    //            }
    //            else
    //            {
    //                throw new ArgumentException("Gender must be 'M' or 'F'");
    //            }
    //        }
    //    }

    //    public Employee(int id, string name, SecurityPrivileges securityLevel, decimal salary, HiringDate hireDate, string gender)
    //    {
    //        ID = id;
    //        Name = name;
    //        SecurityLevel = securityLevel;
    //        Salary = salary;
    //        HireDate = hireDate;
    //        Gender = gender; 
    //    }

    //    public override string ToString()
    //    {
    //        return string.Format("ID: {0}\nName: {1}\nSecurity Level: {2}\nSalary: {3:C}\nHire Date: {4}\nGender: {5}",
    //            ID, Name, SecurityLevel, Salary, HireDate, Gender);
    //    }

    //    public void DisplayDetails()
    //    {
    //        Console.WriteLine(this.ToString());
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        try
    //        {
    //            HiringDate hireDate = new HiringDate(1, 5, 2020);

    //            Employee employee = new Employee(
    //                id: 1,
    //                name: "Ahmed Ali",
    //                securityLevel: SecurityPrivileges.Developer,
    //                salary: 75000.00m,
    //                hireDate: hireDate,
    //                gender: "M" 
    //            );

    //            Console.WriteLine("Employee Details:");
    //            employee.DisplayDetails();
    //        }
    //        catch (ArgumentException ex)
    //        {
    //            Console.WriteLine(ex.Message);
    //        }
    //    }
    //}


    #endregion

    #region q6

    //public class HiringDate
    //{
    //    public int Day { get; set; }
    //    public int Month { get; set; }
    //    public int Year { get; set; }

    //    public HiringDate(int day, int month, int year)
    //    {
    //        Day = day;
    //        Month = month;
    //        Year = year;
    //    }

    //    public override string ToString()
    //    {
    //        return $"{Day:D2}/{Month:D2}/{Year}";
    //    }
    //}

    //public enum SecurityPrivileges
    //{
    //    Guest,
    //    Developer,
    //    Secretary,
    //    DBA
    //}

    //public class Employee
    //{
    //    public int ID { get; set; }
    //    public string Name { get; set; }
    //    public SecurityPrivileges SecurityLevel { get; set; }
    //    public decimal Salary { get; set; }
    //    public HiringDate HireDate { get; set; }

    //    private string gender;
    //    public string Gender
    //    {
    //        get => gender;
    //        set
    //        {
    //            if (value == "M" || value == "F")
    //            {
    //                gender = value;
    //            }
    //            else
    //            {
    //                throw new ArgumentException("Gender must be 'M' or 'F'");
    //            }
    //        }
    //    }

    //    public Employee(int id, string name, SecurityPrivileges securityLevel, decimal salary, HiringDate hireDate, string gender)
    //    {
    //        ID = id;
    //        Name = name;
    //        SecurityLevel = securityLevel;
    //        Salary = salary;
    //        HireDate = hireDate;
    //        Gender = gender; 
    //    }

    //    public override string ToString()
    //    {
    //        return string.Format("ID: {0}\nName: {1}\nSecurity Level: {2}\nSalary: {3:C}\nHire Date: {4}\nGender: {5}",
    //            ID, Name, SecurityLevel, Salary, HireDate, Gender);
    //    }

    //    public void DisplayDetails()
    //    {
    //        Console.WriteLine(this.ToString());
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        try
    //        {
    //            Employee[] EmpArr = new Employee[3];

    //            HiringDate hireDate1 = new HiringDate(1, 5, 2020);
    //            HiringDate hireDate2 = new HiringDate(15, 7, 2021);
    //            HiringDate hireDate3 = new HiringDate(30, 8, 2019);

    //            EmpArr[0] = new Employee(1, "Aya", SecurityPrivileges.DBA, 90000.00m, hireDate1, "F");
    //            EmpArr[1] = new Employee(2, "Omar", SecurityPrivileges.Guest, 50000.00m, hireDate2, "M");
    //            EmpArr[2] = new Employee(3, "Ali", SecurityPrivileges.Developer, 120000.00m, hireDate3, "M");

    //            Console.WriteLine("Employee Details:");
    //            foreach (var employee in EmpArr)
    //            {
    //                employee.DisplayDetails();
    //                Console.WriteLine();
    //            }
    //        }
    //        catch (ArgumentException ex)
    //        {
    //            Console.WriteLine(ex.Message);
    //        }
    //    }
    //}

    #endregion
}
