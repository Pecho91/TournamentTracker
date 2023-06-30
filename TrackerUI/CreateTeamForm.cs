using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> _availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> _selectedTeamMembers = new List<PersonModel>();

        public CreateTeamForm()
        {
            InitializeComponent();

            //CreateSampleData();

            WireUpLists();
        }


        private void CreateSampleData()
        {
            _availableTeamMembers.Add(new PersonModel { FirstName = "Tim", LastName = "Corey" });
            _availableTeamMembers.Add(new PersonModel { FirstName = "Sue", LastName = "Storm" });

            _selectedTeamMembers.Add(new PersonModel { FirstName = "Jane", LastName = "Smith" });
            _selectedTeamMembers.Add(new PersonModel { FirstName = "Bill", LastName = "Jones" });
        }

        private void WireUpLists()
        {
            selectTeamMemberComboBox.DataSource = null;

            selectTeamMemberComboBox.DataSource = _availableTeamMembers;
            selectTeamMemberComboBox.DisplayMember = "FullName";

            teamMembersListBox.DataSource = null;

            teamMembersListBox.DataSource = _selectedTeamMembers;
            teamMembersListBox.DisplayMember = "FullName";

        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel? p = new PersonModel();

                p.FirstName = firstNameTextBox.Text;
                p.LastName = lastNameTextBox.Text;
                p.EmailAddress = emailTextBox.Text;
                p.CellphoneNumber = cellPhoneTextBox.Text;

                p = GlobalConfig.Connection?.CreatePerson(p);

                _selectedTeamMembers.Add(p);

                WireUpLists();

                firstNameTextBox.Text = "";
                lastNameTextBox.Text = "";
                emailTextBox.Text = "";
                cellPhoneTextBox.Text = "";
            }

            else
            {
                MessageBox.Show("You need to fill in all of the fields.");
            }
        }

        private bool ValidateForm()
        {
            if (firstNameTextBox.Text.Length == 0)
            {
                return false;
            }

            if (lastNameTextBox.Text.Length == 0)
            {
                return false;
            }

            if (emailTextBox.Text.Length == 0)
            {
                return false;
            }

            if (cellPhoneTextBox.Text.Length == 0)
            {
                return false;
            }

            return true;
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectTeamMemberComboBox.SelectedItem;

            if (p != null)
            {
                _availableTeamMembers.Remove(p);
                _selectedTeamMembers.Add(p);

                WireUpLists();
            }

        }

        private void removeSelectedMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMembersListBox.SelectedItem;

            if (p != null)
            {
                _selectedTeamMembers.Remove(p);
                _availableTeamMembers.Add(p);

                WireUpLists();
            }

        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();

            t.TeamName = teamNameTextBox.Text;
            t.TeamMembers = _selectedTeamMembers;

            t = GlobalConfig.Connection.CreateTeam(t);

            // TODO - if we aren't closing this form after creation, reset the form.
            
        }
    }
}
