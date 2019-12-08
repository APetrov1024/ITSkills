using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITSkills
{
    public partial class EditForm : Form
    {
        private int employeeID;
        public EditForm()
        {
            InitializeComponent();
        }

        public EditForm(int employeeID)
        {
            this.employeeID = employeeID;
            InitializeComponent();
            RefreshFormData();
        }

        private void RefreshFormData()
        {
            FillProfessionComboBoxValues();
            FillInformation();
            FillProfessionSkillsList();
            FillEmployeeSkillsList();
        }

        private void FillProfessionComboBoxValues()
        {
            var dataContext = new ITSkillsDataContext();
            var professions = from p in dataContext.Professions
                              select p.Profession.ToString();
            foreach (string profession in professions)
            {
                ProfessionComboBox.Items.Add(profession);
            };
        }
        private void FillInformation()
        {
            var dataContext = new ITSkillsDataContext();
            var employees = from e in dataContext.Employees
                            join p in dataContext.Professions on e.ProfessionID equals p.Id
                            where e.Id == this.employeeID
                            select new
                            {
                                Name = e.Name.ToString(),
                                LastName = e.LastName.ToString(),
                                Patronymic = e.Patronymic.ToString(),
                                BirthDate = e.DateOfBirth,
                                Profession = p.Profession.ToString()
                            };
            var employee = employees.First();
            NameTextBox.Text = employee.Name;
            LastNameTextBox.Text = employee.LastName;
            PatronymicTextBox.Text = employee.Patronymic;
            BirthDateTimePicker.Value = employee.BirthDate;
            ProfessionComboBox.SelectedItem = employee.Profession;
        }

        private void FillEmployeeSkillsList()
        {
            var dataContext = new ITSkillsDataContext();
            var skills = from s in dataContext.Skills
                         join es in dataContext.EmployeesSkills on s.Id equals es.SkillID
                         where es.EmployeeID == this.employeeID
                         select s.Skill;
            foreach (string skill in skills)
            {
                EmployeeSkillsListBox.Items.Add(skill);
            }
        }

        private void FillProfessionSkillsList()
        {
            var dataContext = new ITSkillsDataContext();
            var allSkills = from s in dataContext.Skills
                            join e in dataContext.Employees on s.ProfessionID equals e.ProfessionID
                            where e.Id == this.employeeID
                            select s.Skill;
            var employeeSkills = from s in dataContext.Skills
                                 join es in dataContext.EmployeesSkills on s.Id equals es.SkillID
                                 where es.EmployeeID == this.employeeID
                                 select s.Skill;
            foreach (string skill in allSkills.Except<string>(employeeSkills))
            {
                ProfessionSkillsListBox.Items.Add(skill);
            }
        }

        private void AddSkillButton_Click(object sender, EventArgs e)
        {
            string skill = ProfessionSkillsListBox.SelectedItem.ToString();
            ProfessionSkillsListBox.Items.Remove(skill);
            EmployeeSkillsListBox.Items.Add(skill);
        }

        private void removeSkillButton_Click(object sender, EventArgs e)
        {
            string skill = EmployeeSkillsListBox.SelectedItem.ToString();
            EmployeeSkillsListBox.Items.Remove(skill);
            ProfessionSkillsListBox.Items.Add(skill);
        }

        private void saveToDB()
        {
            var dataContext = new ITSkillsDataContext();
            var employee = dataContext.Employees.SingleOrDefault(e => e.Id == this.employeeID);
            employee.Name = NameTextBox.Text;
            employee.LastName = LastNameTextBox.Text;
            if (PatronymicTextBox.Text == "")
                employee.Patronymic = null;
            else
                employee.Patronymic = PatronymicTextBox.Text;
            employee.DateOfBirth = BirthDateTimePicker.Value;
            string newProfession = ProfessionComboBox.SelectedItem.ToString();
            employee.ProfessionID = dataContext.Professions.SingleOrDefault(p => p.Profession == newProfession).Id;
            dataContext.SubmitChanges();
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveToDB();
        }
    }
}
