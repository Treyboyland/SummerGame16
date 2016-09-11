using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class PlayerBoughtCardsList : MonoBehaviour {

	public Player player;
	public GameObject refundButton;
	public bool needs_to_be_updated;
	public float x_spacing;
	public float y_spacing;
	public float x_init_buffer;
	public float y_init_buffer;

	public int buttons_per_row;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (needs_to_be_updated) {
			wipeScreen ();
			List<Ability> abilities = player.abilities;
			for (int i = 0; i < abilities.Count; i++) {
				GameObject button = Instantiate (refundButton, this.gameObject.transform) as GameObject;

				//Setting parameters of the Sellbutton script
				button.GetComponent<SellButton> ().parentUI = this;
				button.GetComponent<SellButton> ().player = player;
				button.GetComponent<SellButton> ().ability_to_sell = abilities [i];

				//Setting the position of the object
				RectTransform button_transform = button.GetComponent<RectTransform> ();
				button_transform.anchorMax = new Vector2 (0, 1);
				button_transform.anchorMin = new Vector2 (0, 1);
				button.transform.localPosition = new Vector3 ((i%buttons_per_row) * button_transform.rect.width + x_init_buffer + x_spacing, (i/buttons_per_row) * button_transform.rect.height + x_init_buffer + x_spacing);

				//Setting the text field
				button.transform.Find("Ability Name and Sell Value").GetComponent<Text>().text = abilities[i].getName() + "\nSell Value: " + Converter.convertCostsToString(abilities[i].getCost());
			}
			needs_to_be_updated = false;
		}
	}

	/// <summary>
	/// Destroys all instances of the refundButton on the screen. Depends on all refundButtons and only refund buttons having the "ResellButton" tag
	/// </summary>
	void wipeScreen(){
		foreach(GameObject a in GameObject.FindGameObjectsWithTag("ResellButton")){
			Destroy (a);
		}
	}

	public void toggleNeedsToBeUpdated(){
		needs_to_be_updated = !needs_to_be_updated;
	}
}
