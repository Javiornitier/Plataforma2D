using UnityEngine;
using System.Collections;

public class CheckPoint : MonoBehaviour {
	private GameControlScript gcs;


	// Use this for initialization
	void Start () {
		gcs = GameObject.Find ("GameControl").GetComponent<GameControlScript> ();
	}
	
void OnTriggerEnter2D(Collider2D objeto){
	if(objeto.tag == "Player"){
		gcs.checkpoint (transform.position);
	}
	}
}
