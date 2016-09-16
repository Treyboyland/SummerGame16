using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Card : MonoBehaviour {

	public string cardName;
	public string description;
	public CardType cardType;
	public bool isFaceUp;


	public Button button;

	// Use this for initialization
	void Start () {
		button.onClick.AddListener (() => cardPicked ());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void cardPicked(){
	}

	public string getName (){
		return this.cardName;
	}

	public string getDescription(){
		return this.description;
	}

	public CardType getCardType(){
		return this.cardType;
	}

	public void flipCard(){
		isFaceUp = !isFaceUp;
	}
}
