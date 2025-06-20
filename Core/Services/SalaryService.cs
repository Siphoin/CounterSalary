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

        public event Action OnChangeValueWeek;
        public event Action OnChangeValueYear;

        public SalaryService()
        {
        }

        [JsonConstructor]
        public SalaryService(Salary salary)
        {
            Salary = salary;
            _culture = CultureInfo.CurrentCulture;
        }


        public override void Initialize()
        {
            Salary = new Salary(_culture);
        }

        public void SetCurrentSalaryOfWeek(long value)
        {
            Salary.ValueWeek = value;
            Salary.CurrentValue = value > 0 ? Salary.CurrentValue + 1 : 0;
            OnChangeValueWeek?.Invoke();
        }

        public void SetCurrentSalaryOfYear(long value)
        {
            Salary.OfYear = value;
            OnChangeValueYear?.Invoke();
        }
    }
}
