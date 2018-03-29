using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
	public int money;
	public int healPoints;
	public int hungry;

	public Text moneyText;
	public GameObject healPointsPanel;
	float healPointsPanelBaseWidth;

	void Awake() {
		AddMoney (0);
	}

	public void AddMoney(int amount) {
		money += amount;
		if (money < 0)
			money = 0;

		moneyText.text = money.ToString ();
	}

	public void PlayerDamage(int amount) {
		if (amount > 0) {
			healPoints -= amount;
			if (healPoints <= 0) {
				// TODO player is dead
			}
		}
	}

	public void PlayerHeal(int amount) {
		if (amount > 0) {
			healPoints += amount;
			if (healPoints > 100) {
				healPoints = 100;
			}
		}
	}
}
