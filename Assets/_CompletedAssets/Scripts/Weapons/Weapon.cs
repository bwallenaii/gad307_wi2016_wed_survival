using UnityEngine;
using System.Collections;

namespace CompleteProject{
	public class Weapon : MonoBehaviour {

		protected bool inGame = true;

		// Update is called once per frame
		void Update () {
			print ("I'm a weapon");
			GetComponent<MeshRenderer> ().enabled = PlayerWeaponManager.canGetWeapon && inGame;
			GetComponent<Collider> ().enabled = PlayerWeaponManager.canGetWeapon && inGame;
		}
	}
}