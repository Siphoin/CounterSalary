using CounterSalary.Core.Services;
using Newtonsoft.Json;
using System;
using System.Globalization;

namespace CounterSalary.Core.Models
{
    [Serializable]
    public class Salary
    {
        private CultureInfo _culture;

        public long Value { get; set; }
        public int Days { get; set; }
        public int Increase { get; set; }
        public Salary() { }

        public Salary(CultureInfo cultureInfo)
        {
            _culture = cultureInfo;
        }


        [JsonConstructor]
        public Salary(long value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value.ToString("C", _culture);
        }
    }
}
