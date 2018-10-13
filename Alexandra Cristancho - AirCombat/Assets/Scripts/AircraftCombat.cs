using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AircraftCombat : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		    this.transform.Translate(0, 0, speed);
		

			if (Input.GetKey(KeyCode.LeftArrow))
			{

				//Esta instruccion rota el gameobject con respecto a su eje Y
				this.transform.Translate(Vector3.left);
			}

			if (Input.GetKey(KeyCode.RightArrow))
			{

				//Esta instruccion rota el gameobject con respecto a su eje Y
				this.transform.Translate(Vector3.right);
			}

			if (Input.GetKey(KeyCode.UpArrow))
			{

				//Esta instruccion rota el gameobject con respecto a su eje Y
				this.transform.Translate(Vector3.up);
			}
			if (Input.GetKey(KeyCode.DownArrow))
			{

				//Esta instruccion rota el gameobject con respecto a su eje Y
				this.transform.Translate(Vector3.down);
			}

		    if (Input.GetKeyDown(KeyCode.Space)){

			//Crear un GameObject apartir de un prefab (planos de un edificio)

			GameObject newMissile = GameObject.Instantiate(Resources.Load("Bullets/Missile") as GameObject);

			GameObject shootPivot = GameObject.Find("AircraftPivot/ShootPivot");

			newMissile.transform.SetParent(shootPivot.transform);

			newMissile.transform.localPosition = Vector3.zero;

			//Saco el misisl del pivote para que no se mueva con el avion//
			newMissile.transform.SetParent(null);

		}
	}
}