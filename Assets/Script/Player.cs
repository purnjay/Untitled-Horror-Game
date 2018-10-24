using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour {

	//Floats
	public float moveSpeed;
	public float jumpForce;

	//Bools
	public bool isGrounded;
	bool canJump;

	//Components

	Rigidbody rigidb;
	public Transform groundCheck;

	// Use this for initialization
	void Start () {

		rigidb = GetComponent<Rigidbody>();
		isGrounded = true;

	}
	
	// Update is called once per frame
	void Update () {

		float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");

		Vector3 moveDirection = new Vector3 (horizontal, 0f, vertical) * moveSpeed * Time.deltaTime;
		transform.Translate (moveDirection);

		isGrounded = Physics.CheckSphere (groundCheck.position, 0.1f);

		if (Input.GetKeyDown (KeyCode.Space) && isGrounded) {
			canJump = !canJump;
		}

	}

	void FixedUpdate(){
		if (canJump) {
			rigidb.AddForce (Vector3.up * jumpForce);
			canJump = !canJump;
		}
	}
}
