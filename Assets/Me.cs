using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Me : MonoBehaviour {

	public CharacterController cc; 
	public float speed = 4f; 

	// Use this for initialization
	void Start () {
		//put this script on a capsule with a CharacterController component on it
		//make sure to parent Main Camera to the capsule, behind it (third person game) or above it? (top-down 2.5D game)

		//make sure you assign this reference in the inspector 
		//declare a public variable of type CharacterController called "cc"

	}
	
	// Update is called once per frame
	void Update () {
		//UPDATE:
		// TODO: make sure to multiply directions and values with speed values 
		// TODO: make sure to make each value FRAMERATE-INDEPENDENT

		//player holds W, call cc.Move(this transform's forward direction)
		if(Input.GetKey(KeyCode.W)){
			cc.Move (transform.forward*speed*Time.deltaTime); 
		} 
			//if player holds S, call cc.Move(this transform's negative forward direction)
		if (Input.GetKey (KeyCode.S)) { 
			cc.Move (transform.forward * -speed * Time.deltaTime); 
		}
		//if player holds A, rotate this transform to the left
		if (Input.GetKey (KeyCode.A)) {
			transform.Rotate (0f, -90f * Time.deltaTime, 0f); 
		}
		//if player holds D, rotate this transform to the right
		if (Input.GetKey (KeyCode.D)) { 
			transform.Rotate (0f, 90f * Time.deltaTime, 0f); 
		} 
				
	}
}
