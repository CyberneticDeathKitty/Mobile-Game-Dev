﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerometer : MonoBehaviour {
		
	}
	
	void Update () 
	
	{
	transform.Translate(Input.acceleration.x, 0, -Input.acceleration.z);
	}

}
