using UnityEngine;
using System.Collections;

public class CubeDestroyer : MonoBehaviour {

	void OnTriggerEnter (Collider other) 
	{
				if (other.tag == "Hazard") {
				

					Destroy (gameObject);
					Destroy (other.gameObject);

				}
		}


}
