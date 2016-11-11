using UnityEngine;
using System.Collections;

public class Moneda3 : MonoBehaviour {
	Rigidbody2D rb;
	GameObject txt_moneda;
	ControlMonedas cm;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody2D> ();
		rb.AddForce (new Vector2 (Random.Range(-100, 100), 100));
		txt_moneda = GameObject.Find ("TextoMoneda"); //Find me busca un objeto en la escena.
		cm = txt_moneda.GetComponent<ControlMonedas>();

	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Player") {
			cm.SumaMonedas (3);
			Destroy (gameObject);
		}
	}
}
