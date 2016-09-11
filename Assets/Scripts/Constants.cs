using UnityEngine;
using System.Collections;
using System;

/// <summary>
/// Shard type. The different types of currency in-game.
/// </summary>
public enum ShardType{
	FIRE,
	WATER,
	EARTH,
	LIGHT,
	DARKNESS,
	ARMOR,
	WEAPON,
}

/// <summary>
/// Ability type. For the core types of cards
/// </summary>
public enum AbilityType{
	SKILL,
	WEAPON,
	ARMOR,
}

public enum Element{
	FIRE,
	WATER,
	EARTH,
	LIGHT,
	DARKNESS,
	ALL,
	NONE,
}

public static class Converter{
	public static string convertCostsToString(int[] cost){
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