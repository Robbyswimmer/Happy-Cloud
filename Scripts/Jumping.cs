using UnityEngine;
using System.Collections;

public class Jumping : MonoBehaviour {

	public float movement;

	void Update () {
		if(Input.anyKeyDown)
		{
			move();
		}
	}

	private void move()
	{
		rigidbody.velocity = new Vector3(0,0,0);
		rigidbody.AddForce (new Vector3(0, movement * 10, 0), ForceMode.Force);
	} 

}