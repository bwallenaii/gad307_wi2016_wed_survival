using UnityEngine;
using System.Collections;

namespace CompleteProject{
	public class HelephantGun : Weapon {

		void OnTriggerEnter(Collider col){
			if (col.gameObject.name == "Player") {
				PlayerWeaponManager.activateHelephantGun ();
			}

		}
	}
}