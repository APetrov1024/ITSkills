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
    public partial class EmployeesListForm : Form
    {
        private bool isNeedToExit;
        public EmployeesListForm()
        {
            InitializeComponent();
            FillEmployeeGrid();
            AtLeastOneProfessionMustExist();
        }

        internal int getProfessionsCount()
        {
            var dataContext = new ITSkillsDataContext();
            var professions = from p in dataContext.Professions
                              select p;
            return professions.Count();
        }

        private void AtLeastOneProfessionMustExist()
        {
            while (getProfessionsCount() == 0)
            {
                DialogResult result = MessageBox.Show(
                "В базе данных необнаружено ни одной профессии. Для корректной работы программы необходимо создать как минимум одну профессию. " +
                "Создать профессию? (Нажмите \"Отмена\" для закрытия программы)",
                "Необходимо добавить профессию",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
                if (result == DialogResult.OK)
                {
                    ProfessionsForm.AddProfession();
                }
                else
                {
                    isNeedToExit = true;
                    break;
                }
            }
        }

        private void FillEmployeeGrid()
        {
            var dataContext = new ITSkillsDataContext();
            var employee = from e in dataContext.Employees
                           join p in dataContext.Professions on e.ProfessionID equals p.Id
                           select new { FullName = String.Format(@"{0} {1} {2}", e.Name, e.LastName, e.Patronymic),
                           DateOfBirth = e.DateOfBirth,
                           Profession = p.Profession,
                           Id = e.Id
                           };
            EmployeesGrid.DataSource = employee;
            EmployeesGrid.Columns[0].HeaderText = "ФИО";
            EmployeesGrid.Columns[1].HeaderText = "Дата рождения";
            EmployeesGrid.Columns[2].HeaderText = "Профессия";
            EmployeesGrid.Columns[3].Visible = false;
        }

        private void EditEmployee()
        {
            int employeeID = Convert.ToInt32(EmployeesGrid.Rows[EmployeesGrid.CurrentCell.RowIndex].Cells[3].Value);
            editForm editForm = new editForm(employeeID);
            editForm.ShowDialog();
            FillEmployeeGrid();
        }

        private void AddEmployee()
        {
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm();
            addEmployeeForm.ShowDialog();
            FillEmployeeGrid();
        }

        private void DeleteEmloyee()
        {
            int employeeID = Convert.ToInt32(EmployeesGrid.Rows[EmployeesGrid.CurrentCell.RowIndex].Cells[3].Value);
            var dataContext = new ITSkillsDataContext();
            var employee = dataContext.Employees.SingleOrDefault(e => e.Id == employeeID);
            dataContext.Employees.DeleteOnSubmit(employee);
            dataContext.SubmitChanges();
            FillEmployeeGrid();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillEmployeeGrid();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EmployeesGrid.CurrentCell != null)
            {
                EditEmployee();
            }
            else
            {
                MessageBox.Show(
                    "Не выбран сотрудник для редактирования",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void addEmployeeStripButton_Click(object sender, EventArgs e)
        {
            AddEmployee();
        }

        private void deleteEmployeeToolStripButton_Click(object sender, EventArgs e)
        {
            if (EmployeesGrid.CurrentCell != null)
            {
                DialogResult result = MessageBox.Show(
                    "Внимание! Данное действие безвозвратно удалит информацию о сотруднике и его навыках. Вы уверены, что хотите удалить сотрудника?",
                    "Предупреждение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                if (result == DialogResult.Yes)
                    DeleteEmloyee();
            }
            else
            {
                MessageBox.Show(
                    "Не выбран сотрудник для удаления",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void SkillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SkillsForm skillsForm = new SkillsForm();
            skillsForm.ShowDialog();
        }

        private void ProfessionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfessionsForm professionsForm = new ProfessionsForm();
            professionsForm.ShowDialog();
            AtLeastOneProfessionMustExist();
            if (isNeedToExit)
                this.Close();
        }

        private void EmployeesGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (EmployeesGrid.CurrentCell != null)
            {
                EditEmployee();
            }
        }

        private void EmployeesListForm_Shown(object sender, EventArgs e)
        {
            if (isNeedToExit)
                this.Close();
        }
    }
}
