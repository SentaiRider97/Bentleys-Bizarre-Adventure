using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Spawn : MonoBehaviour {
	public Transform hydrant; 
	public Transform bush;
	public Transform house1; 
	public Transform dog;   
	public Transform shit; 
	public Transform house2;
	public Transform house3;
	public Transform house4;
	public Transform house5;
	public Transform house6;
	public Transform house7;
	public Transform house8;
	public Transform house9;
	public Transform otherhuman;
	Vector3 dogPos; 
	bool hydrantchecker;
	bool bushchecker; 
	bool house1checker;
	bool house2checker;
	bool house3checker;
	bool house4checker;
	bool house5checker;
	bool house6checker;
	bool house7checker;
	bool house8checker;
	bool house9checker;
	bool otherhumanchecker;
	public Text myText; 
	public int Counter=0; 
	public Canvas victoryCanvas; 

	void Start ()
	{
		victoryCanvas.enabled = false; 	
	}
	
	// Update is called once per frame
	void Update () {
		myText.text = "Poop Collector: " + Counter.ToString ();
		dogPos = dog.transform.position;  
//		Debug.Log (Vector3.Distance (dog.transform.position, hydrant.transform.position)); 
		if (Vector3.Distance (dog.transform.position, hydrant.transform.position) < 8f && hydrantchecker == false) {
			Instantiate (shit, dogPos, Quaternion.identity);
			hydrantchecker = true;
			//Debug.Log ("hydrant");
		}  

		if (Vector3.Distance (dog.transform.position, bush.transform.position) < 10f && bushchecker == false) {
			Instantiate (shit, dogPos, Quaternion.identity);
			bushchecker = true;
			//Debug.Log ("bush");
		} 

		if (Vector3.Distance (dog.transform.position, house1.transform.position) < 20f && house1checker == false) {
			Instantiate (shit, dogPos, Quaternion.identity);
			house1checker = true;
			//Debug.Log ("poop");
		}
		if (Vector3.Distance (dog.transform.position, house2.transform.position) < 20f && house2checker == false) {
			Instantiate (shit, dogPos, Quaternion.identity);
			house2checker = true;
		}
		if (Vector3.Distance (dog.transform.position, house3.transform.position) < 20f && house3checker == false) {
			Instantiate (shit, dogPos, Quaternion.identity);
			house3checker = true;
		}
		if (Vector3.Distance (dog.transform.position, house4.transform.position) < 20f && house4checker == false) {
			Instantiate (shit, dogPos, Quaternion.identity);
			house4checker = true;
		}
		if (Vector3.Distance (dog.transform.position, house5.transform.position) < 20f && house5checker == false) {
			Instantiate (shit, dogPos, Quaternion.identity);
			house5checker = true;
		}
		if (Vector3.Distance (dog.transform.position, house6.transform.position) < 20f && house6checker == false) {
			Instantiate (shit, dogPos, Quaternion.identity);
			house6checker = true;
		}
		if (Vector3.Distance (dog.transform.position, house7.transform.position) < 20f && house7checker == false) {
			Instantiate (shit, dogPos, Quaternion.identity);
			house7checker = true;
		}
		if (Vector3.Distance (dog.transform.position, house8.transform.position) < 20f && house8checker == false) {
			Instantiate (shit, dogPos, Quaternion.identity);
			house8checker = true;
		}
		if (Vector3.Distance (dog.transform.position, house9.transform.position) < 20f && house9checker == false) {
			Instantiate (shit, dogPos, Quaternion.identity);
			house9checker = true;
		}
		if (Vector3.Distance (dog.transform.position, otherhuman.transform.position) < 10f && otherhumanchecker == false) {
			Instantiate (shit, dogPos, Quaternion.identity);
			otherhumanchecker = true;
		}
		if(Counter==10)
		{
			victoryCanvas.enabled = true; 
			Time.timeScale = 0f; 
		}
	}


	public void AddToCounter(){
		Counter++;
	}
}
