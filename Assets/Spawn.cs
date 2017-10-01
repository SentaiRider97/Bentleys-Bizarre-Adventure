using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Spawn : MonoBehaviour {
	public Transform hydrant; 
	public Transform bush;
	public Transform poop; 
	public Transform dog;   
	public Transform shit; 
	Vector3 dogPos; 
	bool hydrantchecker;
	bool bushchecker; 
	bool poopchecker;
	public Text myText; 
	public int Counter=0; 
	
	// Update is called once per frame
	void Update () {
		myText.text = "Poop Collector: " + Counter.ToString ();
		dogPos = dog.transform.position;  
		if (Vector3.Distance (dog.transform.position, hydrant.transform.position) < 3f && hydrantchecker == false) {
			Instantiate (shit, dogPos, Quaternion.identity);
			hydrantchecker = true;
		}  

		if (Vector3.Distance (dog.transform.position, bush.transform.position) < 15f  && bushchecker == false) {
			Instantiate (shit, dogPos, Quaternion.identity);
			bushchecker = true;
		} 

		if (Vector3.Distance (dog.transform.position, poop.transform.position) < 5f && poopchecker == false) {
			Instantiate (shit, dogPos, Quaternion.identity);
			poopchecker = true;
		}
			
		if (Vector3.Distance (dog.transform.position, hydrant.transform.position) > 3f && hydrantchecker == true) {
			hydrantchecker = false;
		}
		if (Vector3.Distance (dog.transform.position, bush.transform.position) > 15f && bushchecker == true) {
			bushchecker = false;
		}
		if (Vector3.Distance (dog.transform.position, poop.transform.position) > 5f && poopchecker == true) {
			poopchecker = false;
		}
	}


	public void AddToCounter(){
		Counter++;
	}
}
