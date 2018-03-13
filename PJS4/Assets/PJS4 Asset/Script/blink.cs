using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blink : MonoBehaviour {

	SpriteRenderer s;
	BoxCollider2D b;
	public float refTime = 1;

	void Start()
	{
		s = GetComponent<SpriteRenderer> ();
		b = GetComponent<BoxCollider2D> ();
		StartCoroutine(Example());
	}

	IEnumerator Example()
	{
		while (true){
			yield return new WaitForSeconds(refTime);
			s.enabled = !s.enabled; //NANI ???
			b.enabled = !b.enabled;
		}
	}
}
