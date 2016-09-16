using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Deck. Simulates a stack of cards (Last in, first out)
/// </summary>
public class Deck : MonoBehaviour {

	public List<Card> deck; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	/// <summary>
	/// Shuffle cards in this deck.
	/// </summary>
	public void shuffle(){
		int index_to_place_card = 0;
		for (int i = 0; i < deck.Count; i++) {
			int random_index = Random.Range (i, deck.Count);

			Card temp = deck [index_to_place_card];

			deck [index_to_place_card] = deck [random_index];
			deck [random_index] = temp;
			index_to_place_card++;
		}
	}

	public void showDeck(){
		Debug.Log (deck);
	}

	/// <summary>
	/// Draws a card from the deck.
	/// </summary>
	/// <returns>The last card that was added to the deck.</returns>
	public Card drawCard(){
		Card a = deck [deck.Count-1];
		deck.RemoveAt (deck.Count - 1);
		return a;
	}

	/// <summary>
	/// Adds the card to the deck.
	/// </summary>
	/// <param name="c">Card to add.</param>
	public void addCard(Card c){
		deck.Add (c);
	}

	/// <summary>
	/// Checks to see if this deck still has cards
	/// </summary>
	/// <returns><c>true</c>, if there are still cards in this deck, <c>false</c> otherwise.</returns>
	public bool hasCards(){
		return deck.Count != 0;
	}

	/// <summary>
	/// Returns a copy of the cards in the given deck.
	/// </summary>
	/// <returns>The cards.</returns>
	public List<Card> getCards(){
		List<Card> return_deck = new List<Card> (deck.Count);
		for (int i = 0; i < deck.Count; i++) {
			return_deck [i] = deck [i];
		}
		return return_deck;
	}
}
