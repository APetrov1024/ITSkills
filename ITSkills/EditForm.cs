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
    public partial class editForm : Form
    {
        private int employeeID;
        public editForm()
        {
            InitializeComponent();
            nameTextBox.Validating += nameTextBox_Validating;
            lastNameTextBox.Validating += lastNameTextBox_Validating;
            professionComboBox.Validating += professionComboBox_Validating;
        }

        public editForm(int employeeID)
        {
            this.employeeID = employeeID;
            InitializeComponent();
            nameTextBox.Validating += nameTextBox_Validating;
            lastNameTextBox.Validating += lastNameTextBox_Validating;
            professionComboBox.Validating += professionComboBox_Validating;
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
                professionComboBox.Items.Add(profession);
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
            nameTextBox.Text = employee.Name;
            lastNameTextBox.Text = employee.LastName;
            patronymicTextBox.Text = employee.Patronymic;
            birthDateTimePicker.Value = employee.BirthDate;
            professionComboBox.SelectedItem = employee.Profession;
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
                employeeSkillsListBox.Items.Add(skill);
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
                professionSkillsListBox.Items.Add(skill);
            }
        }

        private void AddSkillButton_Click(object sender, EventArgs e)
        {
            string skill = professionSkillsListBox.SelectedItem.ToString();
            professionSkillsListBox.Items.Remove(skill);
            employeeSkillsListBox.Items.Add(skill);
        }

        private void removeSkillButton_Click(object sender, EventArgs e)
        {
            string skill = employeeSkillsListBox.SelectedItem.ToString();
            employeeSkillsListBox.Items.Remove(skill);
            professionSkillsListBox.Items.Add(skill);
        }

        private void saveToDB()
        {
            var dataContext = new ITSkillsDataContext();
            var employee = dataContext.Employees.SingleOrDefault(e => e.Id == this.employeeID);
            employee.Name = nameTextBox.Text;
            employee.LastName = lastNameTextBox.Text;
            if (patronymicTextBox.Text == "")
                employee.Patronymic = null;
            else
                employee.Patronymic = patronymicTextBox.Text;
            employee.DateOfBirth = birthDateTimePicker.Value;
            string newProfession = professionComboBox.SelectedItem.ToString();
            employee.ProfessionID = dataContext.Professions.SingleOrDefault(p => p.Profession == newProfession).Id;
            foreach (string skill in employeeSkillsListBox.Items)
            {
                EmployeesSkills employeeSkill = new EmployeesSkills();
                employeeSkill.EmployeeID = this.employeeID;
                employeeSkill.SkillID = dataContext.Skills.SingleOrDefault(s => s.Skill == skill).Id;
                var alreadyInDB = from es in dataContext.EmployeesSkills
                                  where es.EmployeeID == employeeSkill.EmployeeID
                                  where es.SkillID == employeeSkill.SkillID
                                  select es;
                if (alreadyInDB.Count() == 0)
                {
                    dataContext.EmployeesSkills.InsertOnSubmit(employeeSkill);
                }
            }
            dataContext.SubmitChanges();
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ValidateChildren();
            if (FormValidator.IsValidated(this, errorProvider1))
                saveToDB();
        }


        private void nameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(nameTextBox.Text))
                errorProvider1.SetError(nameTextBox, "Это поле обязательно к заполнению");
            else
                errorProvider1.SetError(nameTextBox, null);
        }
        private void lastNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(lastNameTextBox.Text))
                errorProvider1.SetError(lastNameTextBox, "Это поле обязательно к заполнению");
            else
                errorProvider1.SetError(lastNameTextBox, null);
        }
        private void professionComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(professionComboBox.Text))
                errorProvider1.SetError(professionComboBox, "Это поле обязательно к заполнению");
            else
                errorProvider1.SetError(professionComboBox, null);
        }
    }
}
