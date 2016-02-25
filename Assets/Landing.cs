using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

namespace CompleteProject{
	public class Landing : MonoBehaviour {

		public Button playBtn;
		public Button exitBtn;

		// Use this for initialization
		void Awake () {

			playBtn.GetComponent<Button> ().onClick.AddListener (() => {playGame();});
			exitBtn.GetComponent<Button> ().onClick.AddListener (() => {quitGame();});
		
		}

		private void playGame(){
			SceneManager.LoadScene (1);
		}

		private void quitGame(){
			Application.Quit ();
		}
	}
}