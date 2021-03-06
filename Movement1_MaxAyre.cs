using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement1_MaxAyre : MonoBehaviour {
	
	public bool moveForward;
	public bool moveBack;
	public bool moveLeft;
	public bool moveRight;
	public float speed1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		moveForward = Input.GetKey (KeyCode.W);
		moveBack = Input.GetKey (KeyCode.S);
		moveLeft = Input.GetKey (KeyCode.A);
		moveRight = Input.GetKey (KeyCode.D);
	}

	void FixedUpdate () {
		if (moveForward == true) {
			transform.position += transform.forward * speed1;
		}
		if (moveBack == true) {
			transform.position -= transform.forward * speed1;
		}
		if (moveLeft == true) {
			transform.position -= transform.right * speed1; 
		}
		if (moveLeft == true) {
			transform.position += transform.right * speed1;
		}

	}
}
//This movement script is simple and does indeed move the player object, but is limited to having controls that are not very dynamic and do not control very smoothly.
//This script could be improved on by having Vector3 based movement rather than the simple transform.position.
//There are limited movement directions, which could have been improved upon. This could be improved by adding further imputs to the script.