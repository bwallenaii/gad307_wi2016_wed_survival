using UnityEngine;
using System.Collections;

namespace CompleteProject
{
	public class PlayerWeaponManager : MonoBehaviour {

		const int WEAPON_TIME = 15;
		const int SPREAD_DAMAGE = 15;
		const int NORMAL_DAMAGE = 20;
		const float NORMAL_SPEED = 0.15f;
		const int HELEPHANT_GUN_DAMAGE = 500;
		const float HELEPHANT_GUN_SPEED = 0.5f; 

		public GameObject leftBarrel;
		public GameObject rightBarrel;
		public GameObject centerBarrel;
		public GameObject decoy;

		private PlayerShooting leftShot;
		private PlayerShooting centerShot;
		private PlayerShooting rightShot;

		private static PlayerWeaponManager pwm;

		private static float weaponTimer = 0;
		// Use this for initialization
		void Awake () {
			pwm = this;

			leftShot = leftBarrel.GetComponent<PlayerShooting> ();
			rightShot = rightBarrel.GetComponent<PlayerShooting> ();
			centerShot = centerBarrel.GetComponent<PlayerShooting> ();

		}
		
		// Update is called once per frame
		void Update () {
			if (!canGetWeapon) {
				weaponTimer -= Time.deltaTime;
			} else {
				resetWeapon ();
			}

			if (Input.GetButtonDown ("Fire2")) {
				Instantiate (decoy, 
					new Vector3(transform.position.x, 1, transform.position.z), 
					transform.rotation);
			}
		}

		private void resetWeapon(){
			leftShot.enabled = false;
			rightShot.enabled = false;

			centerShot.damagePerShot = NORMAL_DAMAGE;
			centerShot.timeBetweenBullets = NORMAL_SPEED;
		}

		private void gotWeapon(){
			weaponTimer = WEAPON_TIME;
		}

		public static void activateSpread(){
			pwm.enableSpread ();
		}

		public void enableSpread(){
			gotWeapon ();
			leftShot.enabled = true;
			rightShot.enabled = true;

			leftShot.damagePerShot = SPREAD_DAMAGE;
			rightShot.damagePerShot = SPREAD_DAMAGE;
			centerShot.damagePerShot = SPREAD_DAMAGE;
		}

		public static void activateHelephantGun(){
			pwm.enableHelephantGun ();
		}

		public void enableHelephantGun(){
			gotWeapon ();
			centerShot.damagePerShot = HELEPHANT_GUN_DAMAGE;
			centerShot.timeBetweenBullets = HELEPHANT_GUN_SPEED;

		}

		public static bool canGetWeapon{
			get{ return weaponTimer <= 0; }
		}
	}
}