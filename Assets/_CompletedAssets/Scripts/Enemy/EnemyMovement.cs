using UnityEngine;
using System.Collections;

namespace CompleteProject
{
    public class EnemyMovement : MonoBehaviour
    {
        Transform player;               // Reference to the player's position.
        PlayerHealth playerHealth;      // Reference to the player's health.
        EnemyHealth enemyHealth;        // Reference to this enemy's health.
        NavMeshAgent nav;               // Reference to the nav mesh agent.

		public float hearingDistance = 5f;
		public float loudHearingDistance = 15f;

		private Vector3 targetLocation;

        void Awake ()
        {
            // Set up the references.
            player = GameObject.FindGameObjectWithTag ("Player").transform;
            playerHealth = player.GetComponent <PlayerHealth> ();
            enemyHealth = GetComponent <EnemyHealth> ();
            nav = GetComponent <NavMeshAgent> ();
			randomLocation ();
        }


        void Update ()
        {
            // If the enemy and the player have health left...
            if(enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0)
            {
                // ... set the destination of the nav mesh agent to the player.
				Vector3 closestDecoy = Decoy.closestDecoy(transform.position);
				float targetDistance = Vector3.Distance(transform.position, targetLocation);
				float playerDistance = Vector3.Distance (transform.position, player.position);
				float decoyDistance = Vector3.Distance (transform.position, closestDecoy);

				if (decoyDistance < loudHearingDistance) {
					targetLocation = closestDecoy;
				}
				else if (playerDistance < hearingDistance || (Input.GetButton ("Fire1") && playerDistance < loudHearingDistance)) {
					targetLocation = player.position;
				}
				else if (targetDistance < 1f) {
					randomLocation ();
				}
                nav.SetDestination (targetLocation);
            }
            // Otherwise...
            else
            {
                // ... disable the nav mesh agent.
                nav.enabled = false;
            }
        }

		private void randomLocation(){
			targetLocation = new Vector3 (Random.Range(-20, 20), 0, Random.Range(-20, 20));
		}
    }
}