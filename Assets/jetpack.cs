using UnityEngine;
using System.Collections;

public class jetpack : MonoBehaviour {

	private Rigidbody rb;
	private bool acc;
	private float speed = 25;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		acc = Input.GetButton("Fire1") || OVRInput.Get(OVRInput.Button);
	
	}

	void FixedUpdate() {
		if (acc) {
			Vector3 spherePosition = Camera.main.gameObject.transform.forward;
			rb.AddForce (spherePosition * speed);
			Debug.Log ("speed: " + rb.velocity.magnitude);

			 
		}
	}
}
