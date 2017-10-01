using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Checkpoints : MonoBehaviour {
	public GameObject player;
	public GameObject hydrant; 
	public GameObject bush; 
	public GameObject dog; 
	public GameObject person; 
	public GameObject poop; 
	public Text myText; 
	bool win;
	Spawn poopy;
	public Me Player; 

	// Use this for initialization
	void Start () {
		poopy = FindObjectOfType<Spawn>();

		myText.text = "Bentley REALLY needs to go poop! Collect 10 pieces of poop to win!";
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance (player.transform.position, hydrant.transform.position) < 5f) {
			myText.text = "Bentley! OMFG! Why you gotta poop literally EVERYWHERE you go?? Weirdo...\n\nOMFG Charlie chill like I gotta express dominace, okay? Whatever let's walk some more."; 
		}
		if (Vector3.Distance (player.transform.position, bush.transform.position) < 15f) {
			myText.text = "Bentley, wait! Don't chase the squirrel! We need to keep walking.\n\n But...but...squirrel = dinner. Okay fine...."; 
		} 
		if (Vector3.Distance (player.transform.position, dog.transform.position) < 5f) {
			myText.text = "I hate everyone here in the south. I miss all my friends in NYC! Oh shit! Bentley stop pulling me! You're gonna rip my arm off.\n\nSQUIRRELLLLLLLL"; 
		}
		if (Vector3.Distance (player.transform.position, person.transform.position) < 5f) {
			myText.text = "Bentley! No! Stop barking! You don't have to provoke EVERY dog you run into!\n\n HAHAHAHA you funny fam!"; 
		}
		if (Vector3.Distance (player.transform.position, poop.transform.position) < 15f) {
			myText.text = "Bentley! Where ya taking me???\n\n I NEED TO POOP HOOMAN GODDAMMIT!"; 
		}
			

		if(poopy.Counter >= 10) {
			myText.text = "Ahhhhhh, god dammit boi! Now I gotta pick it up! Why you gotta make me skip Anime and Chill just so you can poop!\n\nPhew! I feel so much better now! "; 
			Player.enabled = false; 
		}
	}
}
