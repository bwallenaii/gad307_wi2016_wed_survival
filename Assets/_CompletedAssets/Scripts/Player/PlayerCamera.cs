using UnityEngine;
using System.Collections;

namespace CompleteProject{
	public class PlayerCamera : MonoBehaviour {

		const int CEILING_CAMERA_NUMBER = 0;
		const int HEAD_CAMERA_NUMBER = 1;

		public const string CEILING_CAMERA = "ceiling";
		public const string HEAD_CAMERA = "head";

		public Camera ceilingCam;
		public Camera headCam;

		private static int camNumber = CEILING_CAMERA_NUMBER;

		// Use this for initialization
		void Start () {
			headCam.enabled = false;
		}
		
		// Update is called once per frame
		void Update () {

			if (Input.GetButtonDown ("Fire3")) {
				if (camNumber == CEILING_CAMERA_NUMBER) {
					camNumber = HEAD_CAMERA_NUMBER;
					headCam.enabled = true;
					ceilingCam.enabled = false;
				} else if (camNumber == HEAD_CAMERA_NUMBER) {
					camNumber = CEILING_CAMERA_NUMBER;
					headCam.enabled = false;
					ceilingCam.enabled = true;
				}
			}

		}

		public static string cameraLabel{
			get{ 
				switch (camNumber) {
				case CEILING_CAMERA_NUMBER:
					return CEILING_CAMERA;
					break;
				case HEAD_CAMERA_NUMBER:
					return HEAD_CAMERA;
					break;
				default:
					return CEILING_CAMERA;
					break;
				}
			}

		}
	}
}
