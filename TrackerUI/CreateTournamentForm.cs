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
    public partial class CreateTournamentForm : Form
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

            if (t != null )
            {
                _availableTeams.Remove(t);
                _selectedTeams.Add(t);

                WireUpLists();
            }
        }
    }
}
