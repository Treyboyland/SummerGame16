using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DrawLogic : MonoBehaviour {

	List<Player> players;
	public Deck shared_element_deck;

	// Use this for initialization
	void Start () {

		/*Iterates over all cards for all players, adding the normal cards to the master deck,
		 * and the special cards to the respective player's special deck
		 */
		foreach (Player p in players) {
			Deck add_to_master_deck = p.player_customized_deck;
			foreach (Card c in add_to_master_deck.getCards()) {
				if (c.getCardType() != CardType.NORMAL) {
					p.game_special_cards.addCard (c);
				} else {
					shared_element_deck.addCard (c);
				}
			}
			//Shuffle the player's special deck;
			p.game_special_cards.shuffle();
		}

		//Shuffle the element cards
		shared_element_deck.shuffle();

		StartCoroutine ("BeginGame");
	}

	/// <summary>
	/// Handles all of the game logic
	/// </summary>
	/// <returns>The game.</returns>
	IEnumerator BeginGame(){
		/*int current_player = 0;
		while (shared_element_deck.hasCards ()) {
			yield return
		}*/
		yield return null;
	}


	
	// Update is called once per frame
	void Update () {
	
	}
}
