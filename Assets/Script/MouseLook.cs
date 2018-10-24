using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour {

	//Vector
	//Mouse Direction
	private Vector2 mouseDirection;

	private Transform myBody;

	//Float
	[Range(2,6)]
	public int mouseSenstivity = 1;

	// Use this for initialization
	void Start () {
		myBody = this.transform.parent.transform;
	}
	
	// Update is called once per frame
	void Update () {

		Cursor.lockState = CursorLockMode.Locked;

		//How Much the mouse is moved? will be asked every frame.

		Vector2 mouseChange = new Vector2(Input.GetAxisRaw ("Mouse X"),
			                              Input.GetAxisRaw("Mouse Y"));
		mouseDirection += mouseChange * mouseSenstivity;

		this.transform.localRotation =  Quaternion.AngleAxis(-mouseDirection.y, Vector3.right);

		myBody.localRotation = Quaternion.AngleAxis (mouseDirection.x, Vector3.up);
	
	}
}
