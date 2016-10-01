using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other) {
        
        // Deactivating Pick Up object after collision.
        if (other.gameObject.CompareTag ("Pick Up")) {
            other.gameObject.SetActive (false);
        }

    }
}
