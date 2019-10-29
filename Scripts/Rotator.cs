using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

		public float tumble;
		
	
		void Start ()
		{
		rigidbody.angularVelocity = Random.insideUnitSphere * tumble; 
		}
 	

	}