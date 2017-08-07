public class Blackjack
    {
        static Random rand = new Random();
        const int CARD_MIN = 1; 
        const int CARD_MAX = 11;
        const int HOLD_LIMIT = 14;
        const int TWENTY_ONE = 21;
        
        public static void Main(string[] args)
        {
            int total = 0;
            
            // Alert the user of their starting score.
            Console.WriteLine("Your current score is " + total);
            
            // Game loop
            while (total < TWENTY_ONE)
            {
                // Draw a new card
                int newcard = rand.Next(CARD_MIN , CARD_MAX + 1);
                
                // Tell user what their new card is
                Console.WriteLine("Draw: " + newcard);
                
                // Update user total
                total += newcard;
                
                // Write new total
                Console.WriteLine("Total: " + total + "\n");
                
                // If the user hasn't "busted"...
                if (total < TWENTY_ONE)
                    // Iterate the loop again
                    continue;
                
                // Tell user if they have won/lost using nested ternary operators.
                string message = total == TWENTY_ONE ? "You win!" : (total > TWENTY_ONE ? "You lose!" : "Error");
                Console.WriteLine(message);                
                
            }
        }
    }
