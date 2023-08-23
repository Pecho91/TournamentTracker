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
using Windows.Security.EnterpriseData;

namespace TrackerUI
{
    public partial class CreateTournamentForm : Form, IPrizeRequester, ITeamRequester
    {
        private List<TeamModel> _availableTeams = GlobalConfig.Connection.GetTeam_All();
        private List<TeamModel> _selectedTeams = new List<TeamModel>();
        private List<PrizeModel> _selectedPrizes = new List<PrizeModel>();
        public CreateTournamentForm()
        {
            InitializeComponent();

            WireUpLists();
        }

        private void WireUpLists()
        {
            selectTeamComboBox.DataSource = null;
            selectTeamComboBox.DataSource = _availableTeams;
            selectTeamComboBox.DisplayMember = "TeamName";

            tournamentTeamsListBox.DataSource = null;
            tournamentTeamsListBox.DataSource = _selectedTeams;
            tournamentTeamsListBox.DisplayMember = "TeamName";

            prizesListBox.DataSource = null;
            prizesListBox.DataSource = _selectedPrizes;
            prizesListBox.DisplayMember = "PlaceName";
        }

        private void addTeamButton_Click(object sender, EventArgs e)
        {

            TeamModel t = (TeamModel)selectTeamComboBox.SelectedItem;

            if (t != null)
            {
                _availableTeams.Remove(t);
                _selectedTeams.Add(t);

                WireUpLists();
            }
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            // call the CreatePrizeForm
            CreatePrizeForm frm = new CreatePrizeForm(this);
            frm.Show();
        }

        public void PrizeComplete(PrizeModel model)
        {
            // get back from the form a PrizeModel
            _selectedPrizes.Add(model);
            WireUpLists();

            // Take the PrizeModel and put it into our list of selected prizes
        }

        public void TeamComplete(TeamModel model)
        {
            _selectedTeams.Add(model);
            WireUpLists();
        }

        private void createNewTeamLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm frm = new CreateTeamForm(this);
            frm.Show();
        }

        private void removeSelectedPlayerButton_Click(object sender, EventArgs e)
        {

            TeamModel t = (TeamModel)tournamentTeamsListBox.SelectedItem;

            if (t != null)
            {
                _selectedTeams.Remove(t);
                _availableTeams.Add(t);

                WireUpLists();
            }
        }

        private void removeSelectedPrizeButton_Click(object sender, EventArgs e)
        {
            PrizeModel p = (PrizeModel)prizesListBox.SelectedItem;

            if (p != null)
            {
                _selectedPrizes.Remove(p);

                WireUpLists();
            }
        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            // Validate data
            decimal fee = 0;

            bool feeAcceptable = decimal.TryParse(entryFeeTextBox.Text, out fee);
          
            if (!feeAcceptable)
            {
                MessageBox.Show("You need to enter a valid Entry Fee.", 
                                "Invalid Fee", 
                                 MessageBoxButtons.OK, 
                                 MessageBoxIcon.Error);
                return;
            }
            //Create our tournament model
            TournamentModel tm = new TournamentModel();

            tm.TournamentName = tournamentNameTextBox.Text;
            tm.EntryFee = fee;

            tm.Prizes = _selectedPrizes;
            tm.EnteredTeams = _selectedTeams;

            // TODO - Wire our matchups
            TournamentLogic.CreateRounds(tm);

            // Create Tournament Entry
            // Create all of the prizes entries
            // Create all of team entries
            GlobalConfig.Connection.CreateTournament(tm);

            this.Close();
        }
    }
}
