using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

namespace CompleteProject{
	public class Landing : MonoBehaviour {

		public Button playBtn;
		public Button exitBtn;

		public Toggle spreadWeapon;
		public Toggle helephantGun;

		// Use this for initialization
		void Awake () {

			playBtn.GetComponent<Button> ().onClick.AddListener (() => {playGame();});
			exitBtn.GetComponent<Button> ().onClick.AddListener (() => {quitGame();});

		}

		private void playGame(){
			Spread.spreadOn = spreadWeapon.isOn;
			HelephantGun.helephantGunOn = helephantGun.isOn;
			SceneManager.LoadScene (1);
		}

		private void quitGame(){
			Application.Quit ();
		}
	}
}