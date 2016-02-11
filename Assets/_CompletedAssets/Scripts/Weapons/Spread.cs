using UnityEngine;
using System.Collections;

namespace CompleteProject{
	public class Spread : Weapon {

		void OnTriggerEnter(Collider col){
			if (col.gameObject.name == "Player") {
				PlayerWeaponManager.activateSpread ();
			}

		}
	}
}
