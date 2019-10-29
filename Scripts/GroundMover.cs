using UnityEngine;
using System.Collections;

public class GroundMover : MonoBehaviour {

	private Vector3 reset;
	
	void Start () {
		reset = Vector3.right * 2 * 6f;
	}
	
	void Update () {
		Vector3 Trans = Vector3.left * Time.deltaTime;
		transform.Translate (Trans);
		
		if (transform.position.x < -3.5) {
			transform.Translate (reset);
		}
		
	}
}
