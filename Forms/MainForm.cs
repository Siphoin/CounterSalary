using CounterSalary.Core.Models;
using CounterSalary.Core.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
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
            _storageService = (StorageService)Provider.Single(x => x is StorageService);
            _salaryService = (SalaryService)Provider.Single(x => x is SalaryService);
            if (_storageService.Exits<Salary>())
            {
                _salaryService.Salary = await _storageService.Read<Salary>();
            }
            _salaryService.OnChangeValue += OnChangeValueSalary;
            OnChangeValueSalary();
            salary.Value = _salaryService.Salary.Increase;
        }

        private void OnChangeValueSalary()
        {
            salaryText.Text = _salaryService.Salary.ToString();
            daysText.Text = $"Days {_salaryService.Salary.Days}";
        }

        private void Calculate(object sender, EventArgs e)
        {
            long salaryValue = Convert.ToInt64(salary.Text);
            _salaryService.SetCurrentSalaryOfWeek(_salaryService.Salary.Value +  salaryValue);
        }

        private void NewWeek(object sender, EventArgs e)
        {
            _salaryService.SetCurrentSalaryOfWeek(0);
        }

        private async void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            await _storageService.Save(_salaryService.Salary);
        }

        private void salary_ValueChanged(object sender, EventArgs e)
        {
            _salaryService.Salary.Increase = (int)salary.Value;
        }
    }
}
