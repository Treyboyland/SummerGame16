﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class PlayerShardDisplay : MonoBehaviour {

	public Text textbox;
	public Player player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		textbox.text = player.getShardAmounts ();
	}
}
