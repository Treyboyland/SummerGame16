using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

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
		parentUI.toggleNeedsToBeUpdated ();
		player.removeAbility (ability_to_sell);
	}
}
