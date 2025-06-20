using Newtonsoft.Json;
using System;
using System.Globalization;

namespace CounterSalary.Core.Models
{
    [Serializable]
    public class Salary
    {
        private CultureInfo _culture;

        [JsonProperty("Value")]
        public long ValueWeek { get; set; }

        [JsonProperty("Days")]
        public int CurrentValue { get; set; }
        public long OfYear { get; set; }
        public int Increase { get; set; }
        public FormatWorkType Format { get; set; }

        public Salary() { }

        public Salary(CultureInfo cultureInfo)
        {
            _culture = cultureInfo;
        }

        public string GetValueWeek ()
        {
            return ValueWeek.ToString("C", _culture);
        }

        public string GetValueYear ()
        {
            return OfYear.ToString("C", _culture);
        }

       
    }
}
