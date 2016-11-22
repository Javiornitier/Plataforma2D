using UnityEngine;
using System.Collections;

[RequireComponent (typeof(Animator))]
public class MenuScript : MonoBehaviour {
	Animator anim;
	private bool menuPausa = false;
	

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			if (menuPausa) {
				continuar ();
			} else {
				pausa ();
			}
		}
	}

		public void pausa(){
		Time.timeScale = 0;
		menuPausa = true;
		anim.SetBool ("opciones", false);
		anim.SetBool ("pausa", true);
		}

		public void salir(){
		Application.Quit ();
		Debug.Log ("Saliendo");
		}

		public void opciones(){
		anim.SetBool ("opciones", true);
		anim.SetBool ("pausa", true);
		}

		public void continuar(){
		Time.timeScale = 1;
		menuPausa = false;
		anim.SetBool ("opciones", false);
		anim.SetBool ("pausa", false);
		}
}