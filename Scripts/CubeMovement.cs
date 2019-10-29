using UnityEngine;
using System.Collections;

public class CubeMovement : MonoBehaviour {

	public float CubeMover;
	
	void Start () {

		move ();
	}
	
	private void move()
	{
		rigidbody.velocity = new Vector3(0,0,0);
		rigidbody.AddForce (new Vector3(2 * -CubeMover, 0, 0), ForceMode.Force);
	} 
}
