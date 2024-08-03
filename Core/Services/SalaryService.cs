using CounterSalary.Core.Models;
using Newtonsoft.Json;
using System;
using System.Globalization;

namespace CounterSalary.Core.Services
{
    public class SalaryService : ServiceBase
    {
        public Salary Salary { get; set; }

        private readonly CultureInfo _culture;

        public event Action OnChangeValue;

        public SalaryService()
        {
        }

        [JsonConstructor]
        public SalaryService(Salary salary)
        {
            Salary = salary;
        }


        public override void Initialize()
        {
            _culture = CultureInfo.CurrentCulture;
            Salary = new Salary(_culture);
        }

        public void SetCurrentSalaryOfWeek(long value)
        {
            Salary.Value = value;
            Salary.Days = value > 0 ? Salary.Days + 1 : 0;
            OnChangeValue?.Invoke();
        }
    }
}
