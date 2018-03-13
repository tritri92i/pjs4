using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawLine : MonoBehaviour {

	private LineRenderer line;
	//public float maxDist = 9;
	public GameObject circle;

	// Use this for initialization
	void Start () {
		line = GetComponent<LineRenderer> ();
		if (circle == null)
			Debug.Log ("Ah");
	}
	
	// Update is called once per frame
	void Update () {
		displayLine ();
	}

	void displayLine()
	{
		Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		float dist = Vector3.Distance(mousePosition, transform.position);

		if (dist <= circle.GetComponent<DrawCircle>().xradius * gameObject.transform.localScale.x) {
			//Debug.Log(d);
			line.enabled = isActiveAndEnabled;
			line.SetPositions (new Vector3[]{ transform.position, mousePosition });
		} else
			line.enabled = false;
	}
}
