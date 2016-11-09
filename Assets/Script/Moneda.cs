using UnityEngine;
using System.Collections;

public class Moneda : MonoBehaviour {
	Rigidbody2D rb;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody2D> ();
		Destroy (gameObject, 3);
		rb.AddForce (new Vector2 (Random.Range(-200, 200), 200));
			
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Player") {
			Destroy (gameObject);
		}
	}
}
