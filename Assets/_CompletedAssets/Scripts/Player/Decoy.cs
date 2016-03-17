using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace CompleteProject{

	public class Decoy : MonoBehaviour {

		const float DECOY_TIME = 5f;
		private static List<Decoy> decoys = new List<Decoy>();
		private float timeAlive = 0;

		// Use this for initialization
		void Start () {
			decoys.Add (this);
		}
		
		// Update is called once per frame
		void Update () {
			timeAlive += Time.deltaTime;

			if (timeAlive >= DECOY_TIME) {
				decoys.Remove (this);
				Destroy (gameObject);
			}
		}

		public static Vector3 closestDecoy(Vector3 pos){
			float closestDistance = 900;
			Vector3 closestPosition = new Vector3 (0, 900, 0);

			foreach (Decoy decoy in decoys) {
				float curDist = Vector3.Distance (decoy.transform.position, pos);
				if (curDist < closestDistance) {
					closestDistance = curDist;
					closestPosition = decoy.transform.position;
				}
			}

			return closestPosition;
		}
	}
}