﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void GUI()
	{
		if (GUI.Button (UnityEngine.Rect (10, 10, 100, 100), "ROLL")) {
			GameManager.isDiceRoll = true;
		}
	}
}
