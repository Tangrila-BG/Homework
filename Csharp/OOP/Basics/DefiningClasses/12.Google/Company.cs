namespace Csharp.OOP.Basics.DefiningClasses._12.Google
{
    public static partial class _12Google
    {
        private class Company
        {
            private string _name;
            private string _department;
            private decimal _salary;


            public Company(string name, string department, decimal salary)
            {
                _name = name;
                _department = department;
                _salary = salary;
            }

            public Company()
            {
            }

            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }

            public decimal Salary
            {
                get { return _salary; }
                set { _salary = value; }
            }

            public string Department
            {
                get { return _department; }
                set { _department = value; }
            }

            public override string ToString()
            {
                dynamic salary = _salary == 0 ? (dynamic)"" : _salary;
                return $"{_name} {_department} {salary:F2}";
            }
        }
    }

}
