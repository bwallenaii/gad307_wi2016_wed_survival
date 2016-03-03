using UnityEngine;
using System.Collections;

namespace CompleteProject{
	public class Spread : Weapon {

		public static bool spreadOn = true;

		void Start(){
			inGame = spreadOn;
		}

		void OnTriggerEnter(Collider col){
			if (col.gameObject.name == "Player") {
				PlayerWeaponManager.activateSpread ();
			}

		}
	}
}
