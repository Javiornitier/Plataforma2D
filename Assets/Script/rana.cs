using UnityEngine;
using System.Collections;

public class rana : MonoBehaviour {
	Animator anim;

	void Start () {
		anim = GetComponent<Animator> ();
	}

	void OnTriggerEnter2D (Collider2D objeto){
		if (objeto.tag == "Player") {
			anim.SetTrigger ("jump");
		}
	}
}
