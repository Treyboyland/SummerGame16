using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShowBoughtCardsButton : MonoBehaviour {

	public Button button;
	public Text text;
	public GameObject boughtCardsUI;

	const string HIDE_CARDS = "Hide \nBought Cards";
	const string SHOW_CARDS = "Show Bought Cards";

	// Use this for initialization
	void Start () {
		button.onClick.AddListener(() => toggleBoughtCardsUI());
	}
	
	// Update is called once per frame
	void Update () {
	}

	void toggleBoughtCardsUI(){
		if (!boughtCardsUI.activeSelf) {
			boughtCardsUI.SetActive (true);
			boughtCardsUI.GetComponent<PlayerBoughtCardsList> ().needs_to_be_updated = true;
			text.text = HIDE_CARDS;
		} else {
			boughtCardsUI.SetActive (false);
			text.text = SHOW_CARDS;
		}
	}

}
