using System;

namespace empWageProblem
{
    class EmployeeObject
    {
        //constant
        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;
        const int FULL_TIME_EMPLOYEE_HOURS = 8;
        const int PART_TIME_EMPLOYEE_HOURS = 4;
        const int ABSENT_EMPLOYEE_HOURS = 0;

        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;

        //Created an object for the employee
        public EmployeeObject(String company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }

        //To check if employee present or not
        public static int EmployeeCheck()
        {
            //Random class reference
            Random random = new Random();
            int attendance = random.Next(0, 3);
            return attendance;
        }

        //Method to find the total salary of employee
        public void ComputingTheEmployeeSalary()
        {
            //variables
            int employeeHours = 0;
            int totalEmployeeHours = 0;
            int totalEmployeeDays = 0;

            while (totalEmployeeHours <= maxHoursPerMonth && totalEmployeeDays < numOfWorkingDays)
            {
                totalEmployeeDays++;
                // using switch case to check if employee is present or not
                // To check working hours for part-time or full-time employee
                switch (EmployeeCheck())
                {
                    case IS_FULL_TIME:
                        employeeHours = FULL_TIME_EMPLOYEE_HOURS;
                        Console.WriteLine("The full-time employee is present!");
                        break;

                    case IS_PART_TIME:
                        employeeHours = PART_TIME_EMPLOYEE_HOURS;
                        Console.WriteLine("The part-time employee is present!");
                        break;

                    default:
                        employeeHours = ABSENT_EMPLOYEE_HOURS;
                        Console.WriteLine("The employee is absent");
                        break;

                }
                totalEmployeeHours += employeeHours;
                Console.WriteLine("For day : " + totalEmployeeDays + " and hours " + employeeHours);
                Console.WriteLine("Total employee hours : " + totalEmployeeHours);
              
            }
            totalEmpWage = totalEmployeeHours * this.empRatePerHour;
        }

        public string toString()
        {
            return "Total Emp Wage for company: " + this.company + " is : " + this.totalEmpWage ;
        }

    }
}
