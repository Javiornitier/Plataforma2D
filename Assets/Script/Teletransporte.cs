using UnityEngine;
using System.Collections;

public class Teletransporte : MonoBehaviour {

	public Transform destino;

	void OnTriggerEnter2D(Collider2D objeto){
		if (objeto.tag == "Player") {
			objeto.transform.position = destino.position;
		}
	}

	void OnDrawGizmosSelected() {
		if (destino != null) { // != No es igual a null / ! es negar
			Gizmos.color = Color.red;
			Gizmos.DrawLine (transform.position, destino.position);
		}
	}

	void OnDrawGizmos() {
		if (destino != null) {
			Gizmos.color = Color.grey;
			Gizmos.DrawLine (transform.position, destino.position);
		}
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

