using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Loc_0_0Controller : MonoBehaviour {

	public Text Screen0Text;
	public GameObject currentScreen;
	public Text Screen3Input;
	public GameObject Screen4;
	public GameObject Screen5;
	public Text Screen3Text;

	public void ChangeScreen(GameObject newScreen) {
		currentScreen.SetActive (false);
		currentScreen = newScreen;
		currentScreen.SetActive (true);
	}

	public void ContinueWaiting () {
		Screen0Text.text = "Вы просидели еще день. Что собиретесь делать?";
	}

	public void GiveMoney() { 
		int money = int.Parse (Screen3Input.text);
		if (money < 50) {
			ChangeScreen (Screen4);
		} else if (money == 50) {
			ChangeScreen (Screen5);
		} else {
			Screen3Text.text = "У вас нет столько денег";
		}

		
	}
		
}
