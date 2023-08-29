using System;
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

            _tournament.OnTournamentComplete += Tournament_OnTournamentComplete;

            WireUpLists();

            LoadFormData();

            LoadRounds();
        }

        private void Tournament_OnTournamentComplete(object? sender, DateTime e)
        {
            this.Close();
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

        private string ValidateData()
        {
            string output = "";

            double teamOneScore = 0;
            double teamTwoScore = 0;

            bool scoreOneValid = double.TryParse(teamOneScoreTextBox.Text, out teamOneScore);
            bool scoreTwoValid = double.TryParse(teamTwoScoreTextBox.Text, out teamTwoScore);

            if (!scoreOneValid)
            {
                output = "The score One value is not a valid number."; 
            }

            else if (!scoreTwoValid)
            {
                output = "The score Two value is not a valid number.";
            }


            else if (teamOneScore == 0 && teamTwoScore == 0)
            {
                output = "You did not enter a score for either team";
            }

            else if (teamOneScore == teamTwoScore)
            {
                output = "We do not allow ties in this application";
            }

            return output;
        }

        private void scoreButton_Click(object sender, EventArgs e)
        {
            string errorMessage = ValidateData();

            if (errorMessage.Length > 0)
            {
                MessageBox.Show($"Input Error: {errorMessage}");
                return;
            }

            MatchupModel m = (MatchupModel)matchupListBox.SelectedItem;
            double teamOneScore = 0;
            double teamTwoScore = 0;

            if (m == null || m.Entries == null)
            {          
                MessageBox.Show("input and entries are null");
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

            try
            {
                TournamentLogic.UpdateTournamentResults(_tournament);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"The application had the follownig error: {ex.Message}");
                return;
            }
            
            LoadMatchups((int)roundComboBox.SelectedItem);
        }
    }
}       