using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MisileMotion : MonoBehaviour {

    public float motionspeed;

    public float rotationspeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        this.transform.Rotate(rotationspeed, 0, 0);

        this.transform.Translate(Vector3. forward*motionspeed);

	}

	    void OnCollisionEnter(Collision collision){

		//destruimos el misil//
		GameObject.Destroy(this.gameObject);
		GameObject.Destroy(collision.collider.gameObject);


    	} 
	}