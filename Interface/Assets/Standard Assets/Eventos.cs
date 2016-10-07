using UnityEngine;
using System.Collections;

public class Eventos : MonoBehaviour {


	void Start () {
		NewBehaviourScript.Evento += MetodoEjecutar;	
	}

	void MetodoEjecutar(){
		GetComponent<Renderer>().material.color = Random.ColorHSV ();
	}
	
}
