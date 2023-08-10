using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class TournamentViewerForm : Form
    {
        private TournamentModel _tournament;
        List<int> rounds = new List<int>();
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

        private void WireUpList()
        {
            roundComboBox.DataSource = null;
            roundComboBox.DataSource = rounds;
        }
        private void LoadRounds()
        {
            rounds = new List<int>();

            rounds.Add(1);
            int currRound = 1;

            foreach (List<MatchupModel> matchups in _tournament.Rounds)
            {
                // TODO - less22(16min) debugg?
                if (matchups.First().MatchupRound > currRound)
                {
                    currRound = matchups.First().MatchupRound;
                    rounds.Add(currRound);                  
                }
            }

            WireUpList();
        }
    }
}