using UnityEngine;
using System.Collections;

public class sticky : MonoBehaviour {
	
	void OnCollisionEnter2D(Collision2D c) {
		var joint = gameObject.AddComponent<FixedJoint2D>();
		joint.connectedBody = c.rigidbody;
	}
}