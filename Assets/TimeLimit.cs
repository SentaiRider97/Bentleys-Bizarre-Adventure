using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeLimit : MonoBehaviour {

	public Canvas gameoverCanvas;
	float timelimit = 120f;
	public Text secondsText;
	public Text minutesText;
	float seconds = 59.9998f;
	int minutes = 1;

	void Start() {
		gameoverCanvas.enabled = false;
	}

	void Update() {
		timelimit -= Time.deltaTime;

		if (timelimit <= 0.001f) {
			Time.timeScale = 0f;
			gameoverCanvas.enabled = true;
		}

		seconds -= Time.deltaTime;
		if (seconds < 9.5f) {
			secondsText.text = "0" + (Mathf.Round (seconds)).ToString ();
		} else { secondsText.text = (Mathf.Round (seconds)).ToString (); }
		if (seconds <= 0.000001f) {
			seconds = 59f;
			minutes--;
		}

		if (minutes > 0) {
			minutesText.text = (minutes.ToString ()) + ":";
		}
		else { minutesText.text = "0:";}
	}
}
