using UnityEngine;
using System.Collections;

public class PlayerDestroyer : MonoBehaviour {

	

	void OnTriggerEnter (Collider other) 
	{
		if (other.tag == "Player") {
			

			Destroy (other.gameObject);
			
		}
	}


	}

