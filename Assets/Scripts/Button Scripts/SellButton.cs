using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

/// <summary>
/// Sell buttons, found in the "Show Bought Cards" interface.
/// In order for this class to work, ALL buttons have to be named "<AbilityName> Button" (e.g. for an ability called A B, the button would need to be named "A B Button"
/// </summary>
public class SellButton : MonoBehaviour {
	 
	public Button button;
	public Player player;
	public PlayerBoughtCardsList parentUI;
	public Ability ability_to_sell;

	// Use this for initialization
	void Start () {
		button.onClick.AddListener(() => sellAbility());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void sellAbility(){
		for (int i = 0; i < Enum.GetNames (typeof(ShardType)).Length; i++) {
			player.addAmountToShardType (ability_to_sell.getCost () [i], (ShardType)i);
		}
		//parentUI.toggleNeedsToBeUpdated ();
		GameObject.Find (ability_to_sell.getName () + " Button").GetComponent<AbilityButton> ().isBought = false;
		player.removeAbility (ability_to_sell);
		Destroy (this.gameObject);

	}
}
