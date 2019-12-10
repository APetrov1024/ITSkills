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
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
            initProfessionList();
        }

        private void initProfessionList()
        {
            var dataContext = new ITSkillsDataContext();
            var professions = from p in dataContext.Professions
                              select p.Profession.ToString();
            foreach (string profession in professions)
            {
                professionComboBox.Items.Add(profession);
            };
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var dataContext = new ITSkillsDataContext();
            Employees employee = new Employees();
            employee.Name = nameTextBox.Text;
            employee.LastName = lastNameTextBox.Text;
            if (patronymicTextBox.Text == "")
                employee.Patronymic = null;
            else
                employee.Patronymic = patronymicTextBox.Text;
            employee.DateOfBirth = birthDateTimePicker.Value;
            string newProfession = professionComboBox.SelectedItem.ToString();
            employee.ProfessionID = dataContext.Professions.SingleOrDefault(p => p.Profession == newProfession).Id;
            dataContext.Employees.InsertOnSubmit(employee);
            dataContext.SubmitChanges();
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
