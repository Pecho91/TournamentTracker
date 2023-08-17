using TrackerLibrary.Models;
using Windows.Networking.Sockets;

namespace TrackerUI
{
    public partial class TournamentViewerForm : Form
    {
        private TournamentModel _tournament;
        List<int> rounds = new List<int>();
        List<MatchupModel> selectedMatchups = new List<MatchupModel>();
        public TournamentViewerForm(TournamentModel tournamentModel)
        {
            InitializeComponent();

            _tournament = tournamentModel;

            LoadFormData();

            LoadRounds();
        }

        private void LoadFormData()
        {
            tournamentNameLabel.Text = _tournament.TournamentName;
        }

        private void WireUpRoundsList()
        {
            roundComboBox.DataSource = null;
            roundComboBox.DataSource = rounds;
        }

        private void WireUpMatchupsList()
        {
            matchupListBox.DataSource = null;
            matchupListBox.DataSource = selectedMatchups;
            matchupListBox.DisplayMember = "DisplayName";
        }
        private void LoadRounds()
        {
            rounds = new List<int>();

            rounds.Add(1);
            int currRound = 1;

            foreach (List<MatchupModel> matchups in _tournament.Rounds)
            {
                if (matchups.Any() && matchups.First().MatchupRound > currRound)
                {
                    currRound = matchups.First().MatchupRound;
                    rounds.Add(currRound);
                }
            }

            WireUpRoundsList();
        }

        private void roundComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchups();
        }
        // debugg not showin listBox!! less22(40min)
        private void LoadMatchups()
        {

            int round = (int)roundComboBox.SelectedItem;

            foreach (List<MatchupModel> matchups in _tournament.Rounds)
            {

                if (matchups.Count > 0 && matchups.First().MatchupRound == round)
                {
                    selectedMatchups = matchups;
                }

            }

            WireUpMatchupsList();
        }

        private void LoadMatchup()
        {
            MatchupModel m = (MatchupModel)matchupListBox.SelectedItem;

            for (int i = 0; i < m.Entries.Count; i++)
            {
                if (i == 0)
                { 
                    if (m.Entries[0].TeamCompeting != null)
                    {
                        teamOneLabel.Text = m.Entries[0].TeamCompeting.TeamName;
                        teamOneScoreTextBox.Text = m.Entries[0].Score.ToString();
                    }
                    else
                    {
                        teamOneLabel.Text = "Not yet set";
                    }

                }
            }
        }

        private void matchupListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchup();
        }
    }
}