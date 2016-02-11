using UnityEngine;
using System.Collections;

namespace CompleteProject{
	public class Weapon : MonoBehaviour {

		// Update is called once per frame
		void Update () {
			print ("I'm a weapon");
			GetComponent<MeshRenderer> ().enabled = PlayerWeaponManager.canGetWeapon;
			GetComponent<CapsuleCollider> ().enabled = PlayerWeaponManager.canGetWeapon;
		}
	}
}