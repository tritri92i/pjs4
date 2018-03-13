using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fantome : MonoBehaviour {

	BoxCollider2D b;
	SpriteRenderer s;

	// Use this for initialization
	void Start () {
		b = GetComponent<BoxCollider2D> ();
		s = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnCollisionEnter2D(Collision2D other){
		StartCoroutine (Exemple ());
	}

	IEnumerator Exemple()
	{
		yield return new WaitForSeconds(2);
		s.enabled = !s.enabled; //NANI ???
		b.enabled = !b.enabled;
		StartCoroutine(Ex2());
	}

	IEnumerator Ex2(){
		yield return new WaitForSeconds(10);
		s.enabled = !s.enabled; //NANI ???
		b.enabled = !b.enabled;
	}

}
