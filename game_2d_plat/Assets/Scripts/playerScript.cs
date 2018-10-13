using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

	// movemenet variables
	public float maxSpeed;

	Rigidbody2D myRB;
	Animator myAnim;

	// Use this for initialization
	void Start () {
		myRB = GetComponent<Rigidbody2D> ();
		myAnim = GetComponent<Animator> ();

	}

	// Update is called once per frame
	void FixedUpdate () {
		float move = input.getAxis ("Horizontal");

		myRB.velocity = new Vector2 (move * maxSpeed, myRB.velocity.y);
	}
}