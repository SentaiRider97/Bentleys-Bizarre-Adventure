using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpDemPoop : MonoBehaviour {
	private Spawn SpawnScript; 
	// Use this for initialization
	void Start () {
		SpawnScript = FindObjectOfType<Spawn> ();
	}
	
	// Update is called once per frame
	void OnMouseOver(){
		if (Input.GetMouseButtonUp (0)){
			SpawnScript.AddToCounter (); 
			Destroy (gameObject);
		}
	}
}
