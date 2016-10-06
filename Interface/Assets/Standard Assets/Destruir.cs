using UnityEngine;
using System.Collections;

public class Destruir : MonoBehaviour {

	void OnCollisionEnter(Collision col){
		if (col.gameObject.name == "FPSController"){
			Destroy (gameObject);
		}
	}
}
