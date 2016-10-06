using UnityEngine;
using System.Collections;

public class rotacion : MonoBehaviour {

	void OnCollisionEnter(Collision col){
		if (col.gameObject.name == "FPSController"){
			transform.Translate(2,2,2);
		}
	}
}
