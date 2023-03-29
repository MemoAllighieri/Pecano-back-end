namespace proyectotecnicotecano.Utils
{
    public class Salary
    {
        public List<SalaryEmployee> salaries = new List<SalaryEmployee>();

        public Salary()
        {
            salaries = new List<SalaryEmployee>()
            {
                new SalaryEmployee()
                {
                    Type = 0,
                    Hour = 15,
                    Absence = 120,
                    Bonus = 130,
                    Tax = 12
                },
                new SalaryEmployee()
                {
                    Type = 1,
                    Hour = 35,
                    Absence = 280,
                    Bonus = 200,
                    Tax = 16
                },
                new SalaryEmployee()
                {
                    Type = 2,
                    Hour = 85,
                    Absence = 680,
                    Bonus = 350,
                    Tax = 18
                },
            };
        }
    }
    public class SalaryEmployee 
    {
        public int Type { get; set; }
        public int Hour { get; set; }
        public int Absence { get; set; }
        public int Bonus { get; set; }
        public int Tax { get; set; }
    }
}
