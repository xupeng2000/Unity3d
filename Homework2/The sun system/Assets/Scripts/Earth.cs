﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earth : MonoBehaviour {

	Vector3 Sun = new Vector3(0,0,0);
	// Update is called once per frame
	void Update () {
		Vector3 axis = new Vector3(0, 1, 1.5f);
		this.transform.RotateAround(Sun, axis, 15 * Time.deltaTime);
		this.transform.RotateAround(this.transform.position, Vector3.up, 1);

	}
}
