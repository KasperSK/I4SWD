﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using Cardgame.Player;

namespace Cardgame
{
    public class Cardgame
    {
        private List<IPlayer> _players;
        private Deck.Deck _gameDeck;

        public Cardgame()
        {
            _players = new List<IPlayer>();
        } 
        public void AddPlayer(String name)
        {
            _players.Add(new Player.Player(name));
        }

        public void GameLoop()
        {
            Console.WriteLine("--- Welcome to the naive card game! ---");
            Console.WriteLine("Please add players to the game when you are ready to start type \'start\'");

            String input = "";

            do
            {
                Console.Write("Enter player name: ");
                input = Console.ReadLine();
                if (input != "start")
                {
                    AddPlayer(input);
                }
            } while (input != "start");
            _players.Add(new WeakPlayer("densvage"));
            _gameDeck = new Deck.Deck(8);
            
            foreach (var person in _players)
            {
                _gameDeck.DealToPlayer(person, 8);
            }

            foreach (var person in _players)
            {
                Console.WriteLine("");
                person.ShowHand();
            }

            IPlayer winner = null;
            int winValue = 0;
            foreach (var person in _players)
            {
                var personValue = person.ShowTotalValue();
                if (winValue < personValue)
                {
                    winner = person;
                    winValue = personValue;
                }
            }

            Console.WriteLine("The winner is: {0} with a winning hand with the value of {1}", winner.Name, winValue);
        }
    }
}
