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
    public partial class ProfessionsForm : Form
    {
        public ProfessionsForm()
        {
            InitializeComponent();
            InitProfessionsList();
        }

        private void InitProfessionsList()
        {
            professionsListBox.Items.Clear();
            var dataContext = new ITSkillsDataContext();
            var professions = from p in dataContext.Professions
                              select p.Profession.ToString();
            foreach (string profession in professions)
            {
                professionsListBox.Items.Add(profession);
            }
            professionsListBox.SelectedIndex = 0;
        }

        private void AddProfession()
        {
            string newProfessionName = InputDialog.Show("Введите название профессии", "Создание профессии");
            if (newProfessionName != "")
            {
                ITSkillsDataContext dataContext = new ITSkillsDataContext();
                var alreadyInDB = from p in dataContext.Professions
                                  where p.Profession == newProfessionName
                                  select p;
                if (alreadyInDB.Count() == 0)
                {
                    Professions newProfession = new Professions();
                    newProfession.Profession = newProfessionName;
                    dataContext.Professions.InsertOnSubmit(newProfession);
                    dataContext.SubmitChanges();
                }
            }
            InitProfessionsList();
        }

        private void DeleteProfession()
        {
            ITSkillsDataContext dataContext = new ITSkillsDataContext();
            string professionName = professionsListBox.SelectedItem.ToString();
            var profession = dataContext.Professions.SingleOrDefault(p => p.Profession == professionName);
            dataContext.Professions.DeleteOnSubmit(profession);
            dataContext.SubmitChanges();
            InitProfessionsList();
        }

        private bool IsProfessionCanBeDeleted()
        {
            ITSkillsDataContext dataContext = new ITSkillsDataContext();
            string professionName = professionsListBox.SelectedItem.ToString();
            int professionID = dataContext.Professions.SingleOrDefault(p => p.Profession == professionName).Id;
            var employeesWithThisProfessions = from e in dataContext.Employees
                                               where e.ProfessionID == professionID
                                               select e;
            if (employeesWithThisProfessions.Count() == 0)
                return true;
            else
            {
                MessageBox.Show(
                "Удаление невозможно, так как имеются сотрудники с данной профессией.",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
                return false;
            }
        }

        private void addProfessionToolStripButton_Click(object sender, EventArgs e)
        {
            AddProfession();
        }

        private void deleteToolStripButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Внимание! Данное действие безвозвратно удалит информацию о профессии из справочника. Вы уверены, что хотите удалить профессию?",
                "Предупреждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            if ((result == DialogResult.Yes) && IsProfessionCanBeDeleted())
                DeleteProfession();
        }
    }
}
