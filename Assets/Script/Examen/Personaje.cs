using UnityEngine;
using System.Collections;

public class Personaje : MonoBehaviour {

private Rigidbody2D rb;
	public float velocidad = 100f;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.D)) {
			MovimientoDerecha ();
		}
		if (Input.GetKey (KeyCode.A)) {
			MovimientoIzquierda ();
		}
		//if (Input.GetKeyDown (KeyCode.W)) {
			//MovimientoArriba ();
	}

	void MovimientoDerecha (){
			rb.velocity = new Vector2(velocidad, rb.velocity.y);
			this.transform.localScale = new Vector3(1, 1, 1);
		}
	void MovimientoIzquierda (){
			rb.velocity = new Vector2(-velocidad, rb.velocity.y);
			this.transform.localScale = new Vector3(-1, 1, 1);
		}
	}
