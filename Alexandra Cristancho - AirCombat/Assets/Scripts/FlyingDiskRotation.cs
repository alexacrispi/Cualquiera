using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingDiskRotation : MonoBehaviour {

	public float rotationspeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        this.transform.Rotate(0, rotationspeed, 0);
		
	}
}
