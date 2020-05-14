using System;
using System.Collections.Generic;

namespace cards
{
    class Program
    {
        static void Main(string[] args)

        {

            //This is HW from 5/13 - shuffling deck of cards

            /*   REQUIREMENTS:      Your deck should contain 52 unique cards.
            All cards should be represented as as string such as "Ace of Hearts"
            There are four suits: "Clubs", "Diamonds", "Hearts", and "Spades".
            There are 13 ranks: "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10",
            "Jack", "Queen", and "King".     The resultant app must create new deck on start, shuffle them, display top two cards*/


            //review Fisher-Yates algorithm - DONE
            //watch video - DONE
            /*read documentation on random.next() and determine what triggers the action and how one limits the number of actions*/
            //Confirm how many times to run the loop -- that  or make arbitrary decision -- choose enough to show execution of loop
            //confirm the sequence of actions to build the app, as follows here:


            //NOMENCLATURE:         For this Heart = H, Diamond = D, Club = C, Spades =S folllowed by the numeral of the card value.  Ace = 1, Jack = 11, Queen = 12, King = 13 so that H11 is the Jack of Hearts
            //IMPORTANT NOTE:       Test the app with 2 cards in each suit before building out entire deck 

            //Need to establish variables as strings 
            //choose list over array as I will test with two cards in each suit and will need to ADD ITEMS to the list

            //establish variables, set index postion
            //create list --- cards are variables, the deck is the list of variables?

            //select type of loop, am selecting FOR as loop type because there will be a condition

            //Console.WriteLine output --- if we shuffle once meaning we run the algorithm once (for me, run it eight times and then select last two items in output) the last two cards by referencing index position at end of shuffle --> this is the AFTERTHOUGHT -- that is, write out index = 0 and index = 1 values




            var cards = new List<string>() { "H2", "H3", "C4", "C5", "D8", "D9", "S1", "S7" };

            //make n = 8 since we are dealing with 8 elements



            //for firstIndex from n - 1 down to 1 do:
            //this is asking me to make a loop |int++| to take max value and subtract 1, then subtract 1 from that remainder, then 3 then until maxvalue 


            //secondIndex = random integer that is greater than or equal to 0 and LESS than firstIndex
            //this is the random.next()  probably the one where max value is set, in my first version the max value = 8



            /* Now swap the values at firstIndex and secondIndex by doing this:
     firstValue = the value from items[firstIndex]
     secondValue = the value from items[secondIndex]
     items[firstIndex] = secondValue
     items[secondIndex] = firstValue*/

        }
    