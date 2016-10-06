using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	void OnCollisionEnter(Collision col){


		if (col.gameObject.name == "FPSController"){
			GetComponent<Renderer>().material.color = Random.ColorHSV();	
		}
	}
}
