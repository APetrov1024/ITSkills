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
        public EmployeesListForm()
        {
            InitializeComponent();
            FillEmployeeGrid();
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
            int employeeID = Convert.ToInt32(EmployeesGrid.Rows[EmployeesGrid.CurrentCell.RowIndex].Cells[3].Value);
            EditForm editForm = new EditForm(employeeID);
            editForm.Show();
            
        }
    }
}
