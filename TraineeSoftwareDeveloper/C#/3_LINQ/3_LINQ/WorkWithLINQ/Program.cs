// Work with Language-Integrated Query (LINQ) //
// https://learn.microsoft.com/en-us/dotnet/csharp/tutorials/working-with-linq

namespace WorkWithLINQ
{
    internal class Program
    {
        static void Main()
        {
            //IEnumerable<Suit>? suits = Suits();
            //IEnumerable<Rank>? ranks = Ranks();
            var suits = Suits();
            var ranks = Ranks();

            if ((suits is null) || (ranks is null))
                return;

            // 2. Create Deck of Cards //
            // Query for building the deck
            // Query Syntax
            var startingDeck = (from s in suits.LogQuery("Suit Generation")
                                from r in ranks.LogQuery("Rank Generation")
                                select new
                                {
                                    Suit = s,
                                    Rank = r
                                }).LogQuery("Starting Deck");
            // Method Syntax
            //var startingDeckMethod = suits.SelectMany(
            //                                            suit => ranks.Select(
            //                                                rank => new
            //                                                {
            //                                                    Suit = suit,
            //                                                    Rank = rank
            //                                                })
            //                                            );
            // Execution
            foreach (var c in startingDeck)
            {
                Console.WriteLine(c);
            }

            // 3. Manipulate the Order //
            // // Shuffling using InterleaveSequenceWith<T>()
            // Split Deck into two using 'Task' & 'Skip' methods that are part of LINQ APIs
            // 52 cards in a deck, so 52 / 2 = 26
            var top = startingDeck.Take(26);
            var bottom = startingDeck.Skip(26);
            var shuffle = top.InterleaveSequenceWith(bottom);
            foreach (var c in shuffle)
            {
                Console.WriteLine(c);
            }

            // 4. Comparisons // 
            // How many shuffles it takes to set the deck back to its original order?
            var times = 0;
            // We can re-use the shuffle variable from earlier, or you can make a new one
            shuffle = startingDeck;
            do
            {
                // Out Shuffle - where the top and bottom cards stay the same on each run. 

                shuffle = shuffle.Take(26).LogQuery("Top Half")
                    .InterleaveSequenceWith(shuffle.Skip(26)).LogQuery("Bottom Half")
                    .LogQuery("Shuffle"); //8-iterations


                // In Shuffle - where the top and bottom cards stay the same on each run. 
                /*
                shuffle = shuffle.Skip(26).LogQuery("Bottom Half")
                    .InterleaveSequenceWith(shuffle.Take(26)).LogQuery("Top Half")
                    .LogQuery("Shuffle"); //52-iterations
                */
                foreach (var card in shuffle)
                {
                    Console.WriteLine(card);
                }
                Console.WriteLine();
                times++;
            } while (!startingDeck.SequenceEqual(shuffle));
            Console.WriteLine("No. of Shuffles: " + times);
        }

        // 1. Create the Data Set //
        static IEnumerable<string> Suits()
        {
            yield return "clubs";
            yield return "diamonds";
            yield return "hearts";
            yield return "spades";
        }
        static IEnumerable<string> Ranks()
        {
            yield return "two";
            yield return "three";
            yield return "four";
            yield return "five";
            yield return "six";
            yield return "seven";
            yield return "eight";
            yield return "nine";
            yield return "ten";
            yield return "jack";
            yield return "queen";
            yield return "king";
            yield return "ace";
        }

    }
}