using CounterSalary.Core.Models;
using CounterSalary.Core.Services;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CounterSalary
{
    public partial class MainForm : Form
    {
        private SalaryService _salaryService;
        private StorageService _storageService;

        public ServiceProvider Provider { get; }

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(ServiceProvider provider)
        {
            Provider = provider;
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await LoadSaveSalaryData();
        }

        private async Task LoadSaveSalaryData()
        {
            _storageService = (StorageService)Provider.Single(x => x is StorageService);
            _salaryService = (SalaryService)Provider.Single(x => x is SalaryService);
            if (_storageService.Exits<Salary>())
            {
                _salaryService.Salary = await _storageService.Read<Salary>();
            }
            _salaryService.OnChangeValueWeek += OnChangeValueSalary;
            _salaryService.OnChangeValueYear += OnChangeValueYear;
            OnChangeValueSalary();
            salary.Value = _salaryService.Salary.Increase;
            _formatWork.SelectedIndex = (int)_salaryService.Salary.Format;
            _yearText.Text = _salaryService.Salary.GetValueYear();

        }

        private void OnChangeValueSalary()
        {         
            _salaryText.Text = _salaryService.Salary.GetValueWeek();
            _daysText.Text = $"{_salaryService.Salary.Format} {_salaryService.Salary.CurrentValue}";

        }

        private void Calculate(object sender, EventArgs e)
        {
            long salaryValue = Convert.ToInt64(salary.Text);
            _salaryService.SetCurrentSalaryOfWeek(_salaryService.Salary.ValueWeek +  salaryValue);
            _salaryService.SetCurrentSalaryOfYear(_salaryService.Salary.OfYear + salaryValue);
        }

        private void NewWeek(object sender, EventArgs e)
        {
            _salaryService.SetCurrentSalaryOfWeek(0);
        }

        private async void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            await _storageService.Save(_salaryService.Salary);
        }

        private void SalaryWeekChanged(object sender, EventArgs e)
        {
            _salaryService.Salary.Increase = (int)salary.Value;
        }

        private void OnChangeValueYear()
        {
            _yearText.Text = _salaryService.Salary.GetValueYear();
        }

        private void FormatWorkChanged(object sender, EventArgs e)
        {
            _salaryService.Salary.Format = (FormatWorkType)_formatWork.SelectedIndex;
            _daysText.Text = $"{_salaryService.Salary.Format} {_salaryService.Salary.CurrentValue}";
        }

        private void ButtonResetYear_Click(object sender, EventArgs e)
        {
            _salaryService.SetCurrentSalaryOfYear(0);
        }

        private void ButtonCopy_Click(object sender, EventArgs e)
        {
            string data = $"{_salaryService.Salary.CurrentValue} {_salaryService.Salary.Format}:\nYou must pay:\n{_salaryService.Salary.GetValueWeek()}";
            Clipboard.SetText(data);
        }
    }
}
