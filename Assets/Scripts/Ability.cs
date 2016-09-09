using UnityEngine;
using System.Collections;

/// <summary>
/// Ability class. This is used for the cards describing each ability.
/// </summary>
public class Ability{

	string name;
	int[] cost;
	AbilityType type;
	Element element;

	public Ability(string name, int[] cost, AbilityType type, Element ele){
		this.name = name;
		this.cost = cost;
		this.type = type;
		this.element = ele;
	}

	public string getName(){
		return name;
	}

	public int[] getCost(){
		return cost;
	}

	public AbilityType getAbilityType(){
		return type;
	}

	public Element getElement(){
		return element;
	}
}
