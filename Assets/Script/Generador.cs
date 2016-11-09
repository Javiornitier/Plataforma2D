using UnityEngine;
using System.Collections;

public class Generador : MonoBehaviour {
	public GameObject Moneda;
	private GameObject monedaNueva;

	void OnTriggerEnter2D(Collider2D objeto){
		if (objeto.tag == "Player" && monedaNueva == null) {
			//Instantiate (Moneda, transform.position, transform.rotation);
			monedaNueva = (GameObject)Instantiate (Moneda, transform.position, transform.rotation);
		}
	}
}
	