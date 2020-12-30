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
    public partial class CreateTournamentForm : Form, IPrizeRequestor, ITeamRequestor
    {
        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<Prize> selectedPrizes = new List<Prize>();
        public CreateTournamentForm()
        {
            InitializeComponent();

            wireUpLists();
        }

        private void Team1scoreValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void Team1scoreLabel_Click(object sender, EventArgs e)
        {

        }

        private void entryFeeVal_TextChanged(object sender, EventArgs e)
        {

        }

        private void selectTeamDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void wireUpLists()
        {
            selectTeamDropdown.DataSource = null;

            selectTeamDropdown.DataSource = availableTeams;
            selectTeamDropdown.DisplayMember = "TeamName";

            TournamentTeamsListBox.DataSource = null;
            TournamentTeamsListBox.DataSource = selectedTeams;
            TournamentTeamsListBox.DisplayMember = "TeamName";

            prizesListBox.DataSource = null;
            prizesListBox.DataSource = selectedPrizes;
            prizesListBox.DisplayMember = "PlaceName";
        }

        private void AddteamButton_Click(object sender, EventArgs e)
        {

            TeamModel t = (TeamModel)selectTeamDropdown.SelectedItem;

            if (t != null)
            {
                availableTeams.Remove(t);
                selectedTeams.Add(t);

                wireUpLists();
            }
        }

        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {
            // call the CreatePrizeForm
            CreatePrizeForm frm = new CreatePrizeForm(this);
            frm.Show();
        }

        public void prizeComplete(Prize model)
        {
            // get back from the form a PrizeModel
            // Take the prizeModel and put it into our list of selected prizes
            selectedPrizes.Add(model);
            wireUpLists();
        }

        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            wireUpLists();
        }

        private void createNewTeamLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm frm = new CreateTeamForm(this);
            frm.Show();
        }

        private void removeSelectedPlayersButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)TournamentTeamsListBox.SelectedItem;

            if (t != null)
            {
                selectedTeams.Remove(t);
                availableTeams.Add(t);

                wireUpLists();
            }
        }

        private void removeSelectedPrizeButton_Click(object sender, EventArgs e)
        {
            Prize p = (Prize)prizesListBox.SelectedItem;

            if (p != null)
            {
                selectedPrizes.Remove(p);

                wireUpLists();
            }
        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            // validate data
            decimal fee = 0;
            bool validFee = decimal.TryParse(entryFeeVal.Text, out fee);

            if (!validFee)
            {
                MessageBox.Show("The value you entered for Entry Fee is invalid.", 
                                "Invalid Fee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // create tournament model
            Tournament tm = new Tournament();
            tm.tournamentName = TournamentNameValue.Text;
            tm.EntryFee = fee;

            tm.Prizes = selectedPrizes;
            tm.EnteredTeams = selectedTeams;

            // TODO - wire up matchups
            TournamentLogic.createRounds(tm);

            // create tournament entry
            // create all prize entries
            // create all team entries
            GlobalConfig.Connection.createTournamet(tm);        
        }
    }
}
