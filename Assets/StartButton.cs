﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour {

	public string startlevel;

	public void startButton() {
		SceneManager.LoadScene (startlevel);
	}
}
