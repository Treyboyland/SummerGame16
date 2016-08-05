using UnityEngine;
using System.Collections;
using System;

public class Player : MonoBehaviour {

	public int[] shardCounts = new int[Enum.GetNames(typeof(ShardType)).Length];

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
}
