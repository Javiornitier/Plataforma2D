using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ControlMonedas : MonoBehaviour {

	private int monedas = 0; //int numeros positivos o negativos enteros.
	Text texto;

	void Start(){
		texto = GetComponent<Text> ();
		resetear ();
		//SumaMonedas (11); llamar funcion inicio y sumar 11.
	}
	public void SumaMonedas(int cantidad){
		monedas = monedas + cantidad; //monedad += cantidad; (Es lo mismo que lo escrito).
		if (monedas < 0) {
			monedas = 0;

		}
		texto.text = monedas.ToString (); //tostring me crea una cadena de texto.

	}

	public void resetear ()
	{
		monedas = 0;
		texto.text = monedas.ToString ();
	}
}