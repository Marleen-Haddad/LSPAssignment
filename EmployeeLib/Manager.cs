using System;

namespace EmployeeLib
{
    public class Manager : EmployeeHasManager
    {
        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 19.75M;

            Salary = baseAmount + (rank * 4);
        }

    }
}
