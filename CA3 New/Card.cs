using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA3_New
{
    class Card
    {
        public int Worth { get; set; }
        public string Suit { get; set; }
        public string CardName { get; set; }

        public Card(int worth, string suit, string cardname)
        {
            Worth = worth;
            Suit = suit;
            CardName = cardname;
        }
        public Card()
        {

        }


        //THIS METHOD GETS THE CARD NAME BY TAKING IN A NUMBER
        public string GetCardName(int number)
        {
            string card = "";
            if (number == 1 || number == 14 || number == 27 || number == 40)
            {
                card = "Ace";
            }
            else if (number == 2 || number == 15 || number == 28 || number == 41)
            {
                card = "2";
            }
            else if (number == 3 || number == 16 || number == 29 || number == 42)
            {
                card = "3";
            }
            else if (number == 4 || number == 17 || number == 30 || number == 43)
            {
                card = "4";
            }
            else if (number == 5 || number == 18 || number == 31 || number == 44)
            {
                card = "5";
            }
            else if (number == 6 || number == 19 || number == 32 || number == 45)
            {
                card = "6";
            }
            else if (number == 7 || number == 20 || number == 33 || number == 46)
            {
                card = "7";
            }
            else if (number == 8 || number == 21 || number == 34 || number == 47)
            {
                card = "8";
            }
            else if (number == 9 || number == 22 || number == 35 || number == 48)
            {
                card = "9";
            }
            else if (number == 10 || number == 23 || number == 36 || number == 49)
            {
                card = "10";
            }
            else if (number == 11 || number == 24 || number == 37 || number == 50)
            {
                card = "Jack";
            }
            else if (number == 12 || number == 25 || number == 38 || number == 51)
            {
                card = "Queen";
            }
            else if (number == 13 || number == 26 || number == 39 || number == 52)
            {
                card = "King";
            }

            return card;

        }

        //THIS METHOD TAKES IN A NUMBER FROM 1 - 52 AND ASSIGNS IT A VALUE
        public int GetCardWorth(int number)
        {
            int value = 0;
            if (number == 1 || number == 14 || number == 27 || number == 40)
            {
                value = 1;
            }
            else if (number == 2 || number == 15 || number == 28 || number == 41)
            {
                value = 2;
            }
            else if (number == 3 || number == 16 || number == 29 || number == 42)
            {
                value = 3;
            }
            else if (number == 4 || number == 17 || number == 30 || number == 43)
            {
                value = 4;
            }
            else if (number == 5 || number == 18 || number == 31 || number == 44)
            {
                value = 5;
            }
            else if (number == 6 || number == 19 || number == 32 || number == 45)
            {
                value = 6;
            }
            else if (number == 7 || number == 20 || number == 33 || number == 46)
            {
                value = 7;
            }
            else if (number == 8 || number == 21 || number == 34 || number == 47)
            {
                value = 8;
            }
            else if (number == 9 || number == 22 || number == 35 || number == 48)
            {
                value = 9;
            }
            else if (number == 10 || number == 23 || number == 36 || number == 49)
            {
                value = 10;
            }
            else if (number == 11 || number == 24 || number == 37 || number == 50)
            {
                value = 10;
            }
            else if (number == 12 || number == 25 || number == 38 || number == 51)
            {
                value = 10;
            }
            else if (number == 13 || number == 26 || number == 39 || number == 52)
            {
                value = 10;
            }

            return value;

        }

        //THIS METHOD TAKES IN A NUMBER FROM 1-52 AND ASSIGNS A CARD SUIT
        
        public string GetSuit(int number)
        {
            string suit = "";
            if (number <= 13)
            {
                suit = "hearts";

            }
            else if (number >= 14 && number <= 26)
            {
                suit = "clubs";

            }
            else if (number >= 27 && number <= 39)
            {
                suit = "spades";

            }
            else if (number >= 40 && number <= 52)
            {
                suit = "diamonds";

            }
            return suit;
        }
    }
}
