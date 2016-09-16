using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class Player : MonoBehaviour {

	public int[] shardCounts = new int[Enum.GetNames(typeof(ShardType)).Length];
	public List<Ability> abilities = new List<Ability> (); 
	public Deck player_customized_deck;

	public Deck game_special_cards;
	public Deck game_hand;
	public Deck game_acquired_cards;
	public bool isComputer;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	/// <summary>
	/// Gets the amount a player has of a given ShardType.
	/// </summary>
	/// <returns>The number of shards a player has of a particular type.</returns>
	/// <param name="type">Type.</param>
	public int getAmountOfShardType(ShardType type){
		return shardCounts[(int)type];
	}

	/// <summary>
	/// Adds shards of a particular type to the player.
	/// </summary>
	/// <param name="amount">Amount of shards to add.</param>
	/// <param name="type">ShardType.</param>
	public void addAmountToShardType(int amount, ShardType type){
		shardCounts [(int)type] += amount;	
	}

	/// <summary>
	/// Subtracts shards of a particular type to the player.
	/// </summary>
	/// <param name="amount">Amount of shards to subtract.</param>
	/// <param name="type">ShardType.</param>
	public void subtractAmountFromShardType(int amount, ShardType type){
		shardCounts[(int)type] -= amount;
	}


	public string getShardAmounts(){
		string temp = "| | ";

		for (int i = 0; i < shardCounts.Length; i++) {
			temp += shardCounts [i] + " " + Enum.GetName (typeof(ShardType), i) + " | | ";
		}

		return temp;
	}

	/// <summary>
	/// Adds the given ability to the list of player abilities.
	/// </summary>
	/// <param name="ability">Ability.</param>
	public void addAbility(Ability ability){
		abilities.Add (ability);
	}

	/// <summary>
	/// Removes the given ability from the list of player abilities.
	/// </summary>
	/// <param name="ability">Ability.</param>
	public void removeAbility(Ability ability){
		bool removed = abilities.Remove (ability);
		if (removed) {
			Debug.Log (ability.getName () + " removed.");
		} else {
			Debug.Log ("Either " + ability.getName() + " was not removed, or item does not exist");
		}
	}
}
