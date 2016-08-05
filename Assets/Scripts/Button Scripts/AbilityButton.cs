using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class AbilityButton : MonoBehaviour {

	//public ShardType type;
	public int[] cost = new int[Enum.GetNames(typeof(ShardType)).Length];
	public bool isBought;

	public Text ability_text_box;
	public string ability_name;

	public Text description_text_box;
	string temp_description;
	public string description;
	string SOLD = "SOLD!";

	public Text cost_text_box;

	public Button button;
	public Player player;


	// Use this for initialization
	void Start () {
		ability_text_box.text = ability_name;
		description_text_box.text = description;
		temp_description = description;
		cost_text_box.text = getCostString (cost);

		button.onClick.AddListener (() => purchase ());
	}
	
	// Update is called once per frame
	void Update () {
		if (isBought) {
			cost_text_box.text = SOLD;
			button.interactable = false;
		} else {
			if (!canAffordAbility()) {
				button.interactable = false;
			} else {
				button.interactable = true;
			}
			cost_text_box.text = getCostString (cost);
		}

		//Here for the sake of quick testing
		ability_text_box.text = ability_name;
		description_text_box.text = description;
		temp_description = description;

	}

	/// <summary>
	/// Purchase this ability, and subtract cost from the player.
	/// </summary>
	public void purchase(){
		isBought = true;

		for (int i = 0; i < Enum.GetNames (typeof(ShardType)).Length; i++) {
			player.subtractAmountFromShardType (cost [i], (ShardType)i);
		}
	}

	/// <summary>
	/// Determines if the player can afford the given ability by checkingthe player's amount of each type
	/// </summary>
	/// <returns><c>true</c>, The player meets the required cost of the ability, <c>false</c> otherwise.</returns>
	bool canAffordAbility(){
		for (int i = 0; i < Enum.GetNames (typeof(ShardType)).Length; i++) {
			if (cost [i] > player.getAmountOfShardType ((ShardType)i)) {
				return false;
			}
		}
		return true;
	}

	/// <summary>
	/// Gets a string representation of the shard costs.
	/// </summary>
	/// <returns>A string representation of the cost.</returns>
	/// <param name="cost">Cost.</param>
	string getCostString(int[] cost){
		bool free = true;
		string temp = "";
		for (int i = 0; i < cost.Length; i++) {
			if (cost [i] > 0) {
				free = false;
				temp += cost [i] + " " + Enum.GetName (typeof(ShardType), i) + ", ";
			}
		}
		if (free) {
			return "FREE";
		}
		return temp.Substring (0, temp.Length - 2);
	}
}
