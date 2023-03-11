namespace _03.Cards
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Card> cards = new List<Card>();
            string[] input = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < input.Length; i++)
            {
                string[] currentCard = input[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string face = currentCard[0];
                string suit = currentCard[1];
                try
                {
                    Card card = new Card();
                    card = card.CreateCard(face, suit);
                    cards.Add(card);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            foreach (Card card in cards)
            {
                Console.Write($"{card} ");
            }
        }


    }
    public class Card
    {
        readonly List<string> faces = new List<string>() { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };     

        public Card()
        {

        }
        public Card(string face, string suit) : this()
        {
            Face = face;
            Suit = suit;

        }


        public string Face { get; private set; }

        public string Suit { get; private set; }

        public Card CreateCard(string face, string suit)
        {
            if (faces.Contains(face))
            {
                switch (suit)
                {
                    case "S":
                        return new Card(face, "\u2660");
                    case "D":                      
                        return new Card(face, "\u2666");
                    case "H":
                        return new Card(face, "\u2665");
                    case "C":
                        return new Card(face, "\u2663");
                    default:
                        throw new ArgumentException("Invalid card!");
                }
            }
            else
            {
                throw new ArgumentException("Invalid card!");
            }
        }

        public override string ToString()
        {
            return $"[{Face}{Suit}]";
        }
    }
}