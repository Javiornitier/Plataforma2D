using UnityEngine;
using System.Collections;

public class Generador : MonoBehaviour {
	public GameObject[] Monedas;
	private GameObject monedaNueva;
	public Transform posSalida;
	private int numeroMoneda = 0;

	void Start(){
		posSalida = transform.Find ("PosicionSalida").transform;
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Player" && monedaNueva == null) {
			
			numeroMoneda = Random.Range (0, Monedas.Length);
			//Instantiate (Moneda, transform.position, transform.rotation); //&& "Y" || "o"
			monedaNueva = (GameObject)Instantiate (Monedas[numeroMoneda], posSalida.position, transform.rotation);
		}
	}
	void OnTriggerEnter2D(Collider2D objeto){
		if (objeto.tag == "Player" && monedaNueva == null) {
			monedaNueva = (GameObject)Instantiate (Monedas[0], transform.position, transform.rotation);
		}
	}
}
