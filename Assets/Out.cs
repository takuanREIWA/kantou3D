﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Out : MonoBehaviour {
	void OnTriggerEnter (Collider Col){
		if (Col.gameObject.tag == "Player") {
			SceneManager.LoadScene (
				SceneManager.GetActiveScene ().name);
		}
	}
}
