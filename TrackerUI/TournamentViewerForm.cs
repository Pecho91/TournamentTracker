using System.ComponentModel;
using TrackerLibrary;
using TrackerLibrary.Models;
using Windows.Networking.Sockets;

namespace TrackerUI
{
    public partial class TournamentViewerForm : Form
    {
        private TournamentModel _tournament;
        BindingList<int> rounds = new BindingList<int>();
        BindingList<MatchupModel> selectedMatchups = new BindingList<MatchupModel>();

        public TournamentViewerForm(TournamentModel tournamentModel)
        {
            InitializeComponent();

            _tournament = tournamentModel;

            WireUpLists();

            LoadFormData();

            LoadRounds();
        }

        private void LoadFormData()
        {
            tournamentNameLabel.Text = _tournament.TournamentName;
        }

        private void WireUpLists()
        {
            roundComboBox.DataSource = rounds;
            matchupListBox.DataSource = selectedMatchups;
            matchupListBox.DisplayMember = "DisplayName";
        }

        private void LoadRounds()
        {
            rounds.Clear();

            rounds.Add(1);
            int currRound = 1;

            foreach (List<MatchupModel> matchups in _tournament.Rounds)
            {
                if (matchups.First().MatchupRound > currRound)
                {
                    currRound = matchups.First().MatchupRound;
                    rounds.Add(currRound);
                }
            }

            LoadMatchups(1);
        }

        private void roundComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchups((int)roundComboBox.SelectedItem);
        }

        private void LoadMatchups(int round)
        {
            foreach (List<MatchupModel> matchups in _tournament.Rounds)
            {

                if (matchups.First().MatchupRound == round)
                {
                    selectedMatchups.Clear();
                    foreach (MatchupModel m in matchups)
                    {
                        if (m.Winner == null || !unplayedOnlyCheckBox.Checked)
                        {
                            selectedMatchups.Add(m);
                        }
                    }
                }
            }

            if (selectedMatchups.Count > 0) 
            {
                LoadMatchup(selectedMatchups.First()); 
            }

            DisplayMatchupInfo();
        }

        private void DisplayMatchupInfo()
        {
            bool isVisible = (selectedMatchups.Count > 0);

            teamOneLabel.Visible = isVisible;
            teamOneScoreLabel.Visible = isVisible;
            teamOneScoreTextBox.Visible = isVisible;

            teamTwoLabel.Visible = isVisible;        
            teamTwoScoreLabel.Visible = isVisible;
            teamTwoScoreTextBox.Visible = isVisible;

            versusLabel.Visible = isVisible;
            scoreButton.Visible = isVisible;
        }

        private void LoadMatchup(MatchupModel m)
        {
            if (m == null || m.Entries == null)
            {
                // Handle the case where the input or Entries are null.
                // You might want to show an error message or take appropriate action.
                Console.WriteLine("m,entries == null");
                return;
            }

            for (int i = 0; i < m.Entries.Count; i++)
            {
                if (i == 0)
                {
                    if (m.Entries[0].TeamCompeting != null)
                    {
                        teamOneLabel.Text = m.Entries[0].TeamCompeting?.TeamName;
                        teamOneScoreTextBox.Text = m.Entries[0].Score.ToString();

                        teamTwoLabel.Text = "<bye>";
                        teamTwoScoreTextBox.Text = "0";
                    }
                    else
                    {
                        teamOneLabel.Text = "Not yet set";
                        teamOneScoreTextBox.Text = "";
                    }
                }

                if (i == 1)
                {
                    if (m.Entries[1].TeamCompeting != null)
                    {
                        teamTwoLabel.Text = m.Entries[1].TeamCompeting?.TeamName;
                        teamTwoScoreTextBox.Text = m.Entries[1].Score.ToString();
                    }
                    else
                    {
                        teamTwoLabel.Text = "Not yet set";
                        teamTwoScoreTextBox.Text = "";
                    }
                }
            }
        }

        private void matchupListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchup((MatchupModel)matchupListBox.SelectedItem);
        }

        private void unplayedOnlyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            LoadMatchups((int)roundComboBox.SelectedItem);
        }

        private void scoreButton_Click(object sender, EventArgs e)
        {
            MatchupModel m = (MatchupModel)matchupListBox.SelectedItem;
            double teamOneScore = 0;
            double teamTwoScore = 0;

            if (m == null || m.Entries == null)
            {
               
                Console.WriteLine("input and entries are null");
                return;
            }

            for (int i = 0; i < m.Entries.Count; i++)
            {
                if (i == 0)
                {
                    if (m.Entries[0]?.TeamCompeting != null)
                    {                        
                        bool scoreValid = double.TryParse(teamOneScoreTextBox.Text, out teamOneScore);

                        if (scoreValid)
                        {
                            m.Entries[0].Score = teamOneScore;
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid score for team 1.");
                            return;
                        }
                    }
                    
                }

                if (i == 1)
                {
                    if (m.Entries[1]?.TeamCompeting != null)
                    {                        
                        bool scoreValid = double.TryParse(teamTwoScoreTextBox.Text, out teamTwoScore);

                        if (scoreValid)
                        {
                            m.Entries[1].Score = teamTwoScore;
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid score for team 2.");
                            return;
                        }
                    }                
                }
            }

            TournamentLogic.UpdateTournamentResults(_tournament);
            
            LoadMatchups((int)roundComboBox.SelectedItem);
        }
    }
}         //TODO less 24 (15min) - txt bug / refactoring