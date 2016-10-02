using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public int collected = 0;
	GUIText gui;

	// Use this for initialization
	void Start () {
		gui = GetComponent<GUIText> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other) {
        
        // Deactivating Pick Up object after collision.
        if (other.gameObject.CompareTag ("Pick Up")) {
            other.gameObject.SetActive (false);
			collected += 1;
        }

		gui.text = "Collected " + collected + "/10";

    }
}
