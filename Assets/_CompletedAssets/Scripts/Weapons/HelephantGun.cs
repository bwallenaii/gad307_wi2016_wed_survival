using UnityEngine;
using System.Collections;

namespace CompleteProject{
	public class HelephantGun : Weapon {

		public static bool helephantGunOn = true;

		void Start(){
			inGame = helephantGunOn;
		}

		void OnTriggerEnter(Collider col){
			if (col.gameObject.name == "Player") {
				PlayerWeaponManager.activateHelephantGun ();
			}

		}
	}
}