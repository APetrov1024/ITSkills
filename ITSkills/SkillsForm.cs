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
    public partial class SkillsForm : Form
    {
        public SkillsForm()
        {
            InitializeComponent();
            InitProfessionsList();
            professionsListBox.SelectedIndex = 0;
            ShowSkills();
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
        }

        private void ShowSkills()
        {
            skillsListBox.Items.Clear();
            var dataContext = new ITSkillsDataContext();
            string profession = professionsListBox.SelectedItem.ToString();
            int professionID = dataContext.Professions.SingleOrDefault(p => p.Profession == profession).Id;
            var skills = from s in dataContext.Skills
                         where s.ProfessionID == professionID
                         select s.Skill.ToString();
            foreach (string skill in skills)
            {
                skillsListBox.Items.Add(skill);
            }
        }

        private void AddSkill()
        {
            string newSkillName = InputDialog.Show("Введите название навыка", "Создание навыка");
            if (!String.IsNullOrWhiteSpace(newSkillName))
            {
                ITSkillsDataContext dataContext = new ITSkillsDataContext();
                string profession = professionsListBox.SelectedItem.ToString();
                int professionID = dataContext.Professions.SingleOrDefault(p => p.Profession == profession).Id;
                var alreadyInDB = from s in dataContext.Skills
                                  where s.Skill == newSkillName
                                  select s;
                if (alreadyInDB.Count() == 0)
                {
                    Skills newSkill = new Skills();
                    newSkill.Skill = newSkillName;
                    newSkill.ProfessionID = professionID;
                    dataContext.Skills.InsertOnSubmit(newSkill);
                    dataContext.SubmitChanges();
                }
            }
            ShowSkills();
        }

        private void DeleteSkill()
        {
            ITSkillsDataContext dataContext = new ITSkillsDataContext();
            string profession = professionsListBox.SelectedItem.ToString();
            int professionID = dataContext.Professions.SingleOrDefault(p => p.Profession == profession).Id;
            if (skillsListBox.SelectedItems.Count == 1)
            {
                string skillName = skillsListBox.SelectedItem.ToString();
                var skill = dataContext.Skills.SingleOrDefault(s => s.Skill == skillName && s.ProfessionID == professionID);
                dataContext.Skills.DeleteOnSubmit(skill);
                dataContext.SubmitChanges();
            }
            ShowSkills();
        }
        private void professionsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowSkills();
        }

        private void AddSkillToolStripButton_Click(object sender, EventArgs e)
        {
            AddSkill();
        }

        private void DeleteSkillToolStripButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Внимание! Данное действие безвозвратно удалит информацию о навыке из справочника и профилей сотрудников. Вы уверены, что хотите удалить навык?",
                "Предупреждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
                DeleteSkill();
        }
    }
}
