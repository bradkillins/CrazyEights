using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;
using System.Media;

namespace CrazyEights
{
    public partial class Gameboard : Form
    {
        List<HandZone> players = new List<HandZone>();
        int playerTurn = 0;

        HandZone mainPlayerHand;
        HandZone opponent1Hand;
        //HandZone opponent2Hand = players[2];
        //HandZone opponent3Hand = players[3];

        char trumpSuit;
        int pickupCount = 0;
        int moveCount = 0;

        DrawZone drawPile = new DrawZone();
        DiscardZone discardPile = new DiscardZone();
        
        public Gameboard(int numOfOpps)
        {
            InitializeComponent();

            

            suitDropDown.Items.Clear();
            suitDropDown.Items.Add("D");
            suitDropDown.Items.Add("S");
            suitDropDown.Items.Add("H");
            suitDropDown.Items.Add("C");

            suitDropDown.SelectedIndex  = 0;

            players.Add(new HandZone(true));
            players.Add(new HandZone(false));
            //players.Add(new HandZone(false));
            //players.Add(new HandZone(false));

            mainPlayerHand = players[0];
            opponent1Hand = players[1];
            //HandZone opponent2Hand = players[2];
            //HandZone opponent3Hand = players[3];

            NumOfOppsText.Text = numOfOpps.ToString();
            Controls.Add(drawPile);
            drawPile.SetLocation();
            button1.Location = new Point(drawPile.Location.X, drawPile.Location.Y + 170);
            Controls.Add(discardPile);
            discardPile.SetLocation();
            lblSuitTitle.Location = new Point(discardPile.Location.X, discardPile.Location.Y + 180);
            lblTrumpSuit.Location = new Point(discardPile.Location.X + 70, discardPile.Location.Y + 180);
            Controls.Add(mainPlayerHand);
            mainPlayerHand.SetLocation();
            if (numOfOpps == 1)
                Controls.Add(opponent1Hand);
            /*if (numOfOpps == 2)
            {
                Controls.Add(opponent1Hand);
                Controls.Add(opponent2Hand);
            }
            if (numOfOpps == 3)
            {
                Controls.Add(opponent1Hand);
                Controls.Add(opponent2Hand);
                Controls.Add(opponent3Hand);
            }*/

            CardZones.Zones.Add(drawPile);
            CardZones.Zones.Add(discardPile);
            CardZones.Zones.Add(mainPlayerHand);
            CardZones.Zones.Add(opponent1Hand);

            


        }

        private void btnEndGame_Click(object sender, EventArgs e)
        {
            EndGame();
            
        }

        private void CardMouseUp(object sender, MouseEventArgs e)
        {
            Card card = (Card)sender;

            if (discardPile.Bounds.Contains(card.Bounds))
            {
                if(card.zoneBeforeMove == mainPlayerHand && discardPile.IsValidDiscard(card, discardPile.Cards[discardPile.Cards.Count - 1], trumpSuit))
                {
                    //TODO - complete IsValidDiscard method
                    //then set discardPile suit and value appropriatly
                    //we'll also need to handel crazy 8s!
                    
                    mainPlayerHand.TransferCard(discardPile, card);
                    discardPile.AnimatePlacingCardInZone(card);
                    mainPlayerHand.AnimatePlacingCardInZone(null);
                    if (mainPlayerHand.Cards.Count == 0)
                    {
                        EndGame();
                        
                    }
                    else
                    {
                        setSuit(card.Suit, card.Value);

                        playerTurn++;
                        WhoseTurn();
                    }
                    
                }
                else
                    card.FailedMove();              
            }
            else if (mainPlayerHand.Bounds.Contains(card.Bounds))
            {
                //test if player has a playable card before dropping card from drawPile into player's hand
                bool isValid = true;
                //*****************************Validation

                foreach (Card playerCard in mainPlayerHand.Cards)
                {
                    if (playerCard.Value == 8 || playerCard.Value == discardPile.Cards[discardPile.Cards.Count - 1].Value || playerCard.Suit == trumpSuit) isValid = false;
                }

                //if Draw play is valid, drop card into player's hand and then increase pickup count. 
                //if pickup count is at max of 3, then change turns.
                if (card.zoneBeforeMove == drawPile && isValid)
                {
                    card.ShowFace();
                    drawPile.TransferCard(mainPlayerHand, card);
                    mainPlayerHand.AnimatePlacingCardInZone(card);
                    if (drawPile.Cards.Count == 0)
                        discardPile.ShuffleDiscardToDraw(drawPile);

                    if (drawPile.Cards.Count <= 0)
                    {
                        discardPile.ShuffleDiscardToDraw(drawPile);
                    }

                    isValid = false;
                    foreach (Card playerCard in mainPlayerHand.Cards)
                    {
                        if (playerCard.Value == 8 || playerCard.Value == discardPile.Cards[discardPile.Cards.Count - 1].Value || playerCard.Suit == trumpSuit) isValid = true;
                    }

                    //if pickup count is 3 and the pickup card is not valid, change turn.
                    pickupCount++;
                    if (pickupCount >= 3 && !isValid)
                    {
                        playerTurn++;
                        pickupCount = 0;
                        WhoseTurn();
                    }
                    
                }
                else
                    card.FailedMove();
            }
            else
                card.FailedMove();

            
        }

        private void Gameboard_Load(object sender, EventArgs e)
        {
            drawPile.PlaceCardsInPile();
            foreach (Card card in drawPile.Cards)
                card.MouseUp += CardMouseUp;

            //run random code to determine the first player
            playerTurn = RandomPlayerStart();

            //deal cards to each player
            DealCards();

            //place card on Discard pile
            Card discardTop = drawPile.Cards[0];
            discardTop.ShowFace();
            drawPile.TransferCard(discardPile, discardTop);
            discardPile.AnimatePlacingCardInZone(discardTop);
            discardPile.Cards[0].BringToFront();
            trumpSuit = discardPile.Cards[0].Suit;
            SetSuitLabel();

            //lblTrumpSuit.Text = trumpSuit.ToString();


            playerTurn = 0;
            WhoseTurn();
            
            
        }

        private int RandomPlayerStart()
        {
            Random rnd = new Random();
            return rnd.Next(0, players.Count);
        }

        private void WhoseTurn()
        {
            //trumpSuit = suitDropDown.SelectedItem.ToString().ToCharArray()[0];
            bool isValid = false;
            //cycle through list of players;
            if (playerTurn == 1)
            {
                bool cardPlayed = false;
                pickupCount = 0;
                do
                {
                    Card topOfDiscard = discardPile.Cards[discardPile.Cards.Count - 1];
                    AI_Opponent ai = new AI_Opponent();
                    Card move = ai.Move(players[1].Cards, topOfDiscard, trumpSuit);
                    if (move.Value != 14)
                    {
                        players[playerTurn].TransferCard(discardPile, move);
                        discardPile.AnimatePlacingCardInZone(move);
                        discardPile.Cards[discardPile.Cards.Count - 1].BringToFront();
                        players[playerTurn].AnimatePlacingCardInZone(null);
                        trumpSuit = discardPile.Cards[discardPile.Cards.Count - 1].Suit;
                        setSuit(trumpSuit, discardPile.Cards[discardPile.Cards.Count - 1].Value);
                        cardPlayed = true;

                        if (players[playerTurn].Cards.Count == 0)
                        {
                            EndGame();
                        }

                        if (move.Value == 8)
                        {
                            trumpSuit = ai.ChooseSuit(players[playerTurn].Cards);
                            setSuit(trumpSuit, discardPile.Cards[discardPile.Cards.Count - 1].Value);
                        }
                    }
                    else
                    {
                        Card drawTop = drawPile.Cards[0];
                        drawTop.ShowFace();
                        drawPile.TransferCard(players[playerTurn], drawTop);
                        players[playerTurn].AnimatePlacingCardInZone  (drawTop);
                        players[playerTurn].AnimatePlacingCardInZone(null);
                        pickupCount++;

                        if (drawPile.Cards.Count <= 0)
                        {
                            discardPile.ShuffleDiscardToDraw(drawPile);
                        }
                        
                        foreach (Card playerCard in players[playerTurn].Cards)
                        {
                            if (playerCard.Value == 8 || playerCard.Value == discardPile.Cards[discardPile.Cards.Count - 1].Value || playerCard.Suit == trumpSuit) isValid = true;
                        }
                    }
                } while (cardPlayed == false && (pickupCount < 3 || isValid == true));


                //Console.WriteLine(move);
                playerTurn++;
                moveCount++;
                pickupCount = 0;
                if (playerTurn >= players.Count)
                {
                    playerTurn = 0;
                }
            }
            
            
        }

        private void DealCards()
        {
            for (int i = 0; i < players.Count; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    //transfer cards
                    Card card = drawPile.Cards[0];
                    card.ShowFace();
                    drawPile.TransferCard(players[i], card);
                    //mainPlayerHand.AnimatePlacingCardInZone(card);
                    if (drawPile.Cards.Count == 0)
                        discardPile.ShuffleDiscardToDraw(drawPile);
                }
                var cards = players[i].Cards;
                players[i].AnimatePlacingCardInZone(null);
            } 
            /*var cards = mainPlayerHand.Cards;
            mainPlayerHand.AnimatePlacingCardInZone(null);*/

            //cycle through playerTurn and deal out 7 cards to each player
            //mainPlayerHand.Cards.Add(Cards[0]);
            //opponent1Hand.Cards.Add(top card on draw pile);
            //Check mainPlayerHand.Cards.Count == 7 && opponent1Hand.Cards.Count == 7
        }

        private void setSuit(char suit, int value)
        {
            trumpSuit = suit;

            if (value == 8 && playerTurn == 0)
            {
                SuitSelector selector = new SuitSelector();
                if (selector.ShowDialog() == DialogResult.OK)
                {
                    trumpSuit = selector.SelectedSuit;
                }
            }

            SetSuitLabel();




            //changeSuit:;

            //switch (suit)
            //{
            //    case 'D':
            //        suitDropDown.SelectedIndex = 0;
            //        break;
            //    case 'S':
            //        suitDropDown.SelectedIndex = 1;
            //        break;
            //    case 'H':
            //        suitDropDown.SelectedIndex = 2;
            //        break;
            //    case 'C':
            //        suitDropDown.SelectedIndex = 3;
            //        break;
            //}

            //lblTrumpSuit.Text = suit.ToString();

            //if (value == 8 && playerTurn == 0)
            //{
            //    //suitDropDown.Enabled = true;
            //    SuitSelector suitSelector = new SuitSelector();
            //    suitSelector.ShowDialog();
            //    //MessageBox.Show("Hi");
            //    MessageBox.Show(suitSelector.selectedSuit.ToString());
            //    suit = suitSelector.selectedSuit;
            //    value = 0;
            //    goto changeSuit;
            //}
            //else
            //{
            //    suitDropDown.Enabled = false;
            //}

        }

        void SetSuitLabel()
        {
            string selectedSuit = "";

            switch (trumpSuit)
            {
                case 'D':
                    selectedSuit = "Diamonds";
                    break;
                case 'S':
                    selectedSuit = "Spades";
                    break;
                case 'H':
                    selectedSuit = "Hearts";
                    break;
                case 'C':
                    selectedSuit = "Clubs";
                    break;
            }

            lblTrumpSuit.Text = selectedSuit;
        }

        private void EndGame()
        {
            if (players[playerTurn].Cards.Count == 0)
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.winner2);
                player.Play();
                MessageBox.Show($"Player {playerTurn + 1} won!");

                //#region Testing
                ////Parameters are as follows
                ////int playerWon, int playerLost, int leastNumberOfCardsPlayed, int mostNumberOfCardsPlayed)
                //CrazyEights.Classes.Stats.UdpateStats(0, 1, 10, 20);
                bool playerWon = false;
                if (playerTurn == 0)
                {
                    playerWon = true;
                }
                CrazyEights.Classes.Stats.UdpateStats(playerWon, moveCount);
                //++++++++++++++++++++++++++++++++++++++++++++++++++++++
                //We want to pass moveCount and a bool playerWon to the UpdateStats method;

                ////This will return ',' seperated string like 1,0,10,20,
                //MessageBox.Show(CrazyEights.Classes.Stats.GetStats());
                //#endregion

            }
            CardZones.Zones.Clear();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            discardPile.ShuffleDiscardToDraw(drawPile);
        }
    }
}
