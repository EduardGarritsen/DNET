using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicum1
{
    public partial class Form1 : Form
    {
        TicTacToeEngine t = new TicTacToeEngine();
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            b.Text = t.AssignCell(Int32.Parse(b.Name.Substring(b.Name.Length - 1)));
            b.Enabled = false;
            t.CheckWinner();
            if(t.Gamestate != GameState.PlayerOPlays && t.Gamestate != GameState.PlayerXPlays)
            {
                String message = "status: " + t.Gamestate.ToString();
                if (t.Gamestate == GameState.PlayerOWins) 
                {
                    message = "Gefeliciteerd! Speler O wint";
                }
                else if (t.Gamestate == GameState.PlayerXWins)
                {
                    message = "Gefeliciteerd! Speler X wint";
                }
                else if (t.Gamestate == GameState.Equal)
                {
                    message = "Gelijkspel! Geen speler wint";
                }
                System.Windows.Forms.MessageBox.Show(message);
            }
        }
    }
}
