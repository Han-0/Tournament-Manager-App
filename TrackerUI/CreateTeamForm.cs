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

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        private List<Person> availableTeamMembers = GlobalConfig.Connection.getPerson_All();
        private List<Person> selectedTeamMembers = new List<Person>();
        private ITeamRequestor callingForm;

        public CreateTeamForm(ITeamRequestor caller)
        {
            InitializeComponent();

            callingForm = caller;

            //createSampleData();

            wireUpLists();
        }

        private void createSampleData()
        {
            availableTeamMembers.Add(new Person { FirstName = "jim", LastName = "phillie" } );
            availableTeamMembers.Add(new Person { FirstName = "sue", LastName = "smith" });

            selectedTeamMembers.Add(new Person { FirstName = "jane", LastName = "jameson" });
            selectedTeamMembers.Add(new Person { FirstName = "bill", LastName = "jons" });
        }

        private void wireUpLists()
        {
            selectTeamMemeberDropdown.DataSource = null;

            selectTeamMemeberDropdown.DataSource = availableTeamMembers;
            selectTeamMemeberDropdown.DisplayMember = "fullName";

            teamMembersListBox.DataSource = null;

            teamMembersListBox.DataSource = selectedTeamMembers;
            teamMembersListBox.DisplayMember = "fullName";
        }

        private void firstNameValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                Person p = new Person();

                p.FirstName = firstNameValue.Text;
                p.LastName = LastNameValue.Text;
                p.EmailAddress = emailval.Text;
                p.CellphoneNum = cellphoneVal.Text;

                p = GlobalConfig.Connection.CreatePerson(p);

                selectedTeamMembers.Add(p);

                wireUpLists();

                firstNameValue.Text = "";
                LastNameValue.Text = "";
                emailval.Text = "";
                cellphoneVal.Text = "";
            }
            else
            {
                MessageBox.Show("You need to fill in all of the fields.");
            }
        }

        private bool ValidateForm()
        {
            if (firstNameValue.Text.Length == 0)
            {
                return false;
            }
            if (LastNameValue.Text.Length == 0)
            {
                return false;
            }
            if (emailval.Text.Length == 0)
            {
                return false;
            }
            if (cellphoneVal.Text.Length == 0)
            {
                return false;
            }

            return true;
        }

        private void AddteamButton_Click(object sender, EventArgs e)
        {
            Person p = (Person) selectTeamMemeberDropdown.SelectedItem;

            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                wireUpLists(); 
            }
        }

        private void removeSelectedMemberButton_Click(object sender, EventArgs e)
        {
            Person p = (Person)teamMembersListBox.SelectedItem;

            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);

                wireUpLists(); 
            }
        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();

            t.TeamName = teamNameValue.Text;
            t.TeamMembers = selectedTeamMembers;

            GlobalConfig.Connection.CreateTeam(t);

            callingForm.TeamComplete(t);

            this.Close();
        }
    }
}
