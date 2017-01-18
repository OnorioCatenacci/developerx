<Query Kind="Program" />

/* NB This code is for demonstration purposes ONLY!  
   Don't write your code like this!
*/

void Main()
{
	var RoyalFlush = new List<PlayingCard>
	{
		new PlayingCard(CardSuits.Hearts, CardRanks.Ace),
		new PlayingCard(CardSuits.Hearts, CardRanks.King),
		new PlayingCard(CardSuits.Hearts, CardRanks.Queen),
		new PlayingCard(CardSuits.Hearts, CardRanks.Jack),
		new PlayingCard(CardSuits.Hearts, CardRanks.Ten)
	};
	
}

public enum CardSuits
{
	Hearts,
	Diamonds,
	Clubs,
	Spades
}

public enum CardRanks
{
	Two,
	Three,
	Four,
	Five,
	Six,
	Seven,
	Eight,
	Nine,
	Ten,
	Jack,
	Queen,
	King,
	Ace
}

public class PlayingCard
{
	private readonly CardSuits _suit;
	private readonly CardRanks _rank;

	public PlayingCard(CardSuits suit, CardRanks rank)
	{
		_suit = suit;
		_rank = rank;
	}
}