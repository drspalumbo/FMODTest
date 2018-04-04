using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public Rigidbody rb;
	public float moveForce = 100f;
	public float jumpForce;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey(KeyCode.A)){
			rb.AddForce(-1 * moveForce, 0, 0) ;
		}
		if (Input.GetKey(KeyCode.S)){
			rb.AddForce(0, 0, -1 * moveForce);
		}
		if (Input.GetKey(KeyCode.D)){
			rb.AddForce(1 * moveForce, 0, 0);
		}
		if (Input.GetKey(KeyCode.W)){
			rb.AddForce(0, 0, 1 * moveForce);
		}
		if (Input.GetKeyDown(KeyCode.Space))
		{
			rb.AddForce(0, 1 * jumpForce,0);
		}

	}
}
