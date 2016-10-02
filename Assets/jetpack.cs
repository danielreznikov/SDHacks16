using UnityEngine;
using System.Collections;

public class jetpack : MonoBehaviour {

	private Rigidbody rb;
	private float rightTrigger;
    private float leftTrigger;
	private float speed = 500;
    private float brakeCoef = 50;
    private Vector3 maxSpeed;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
        maxSpeed = new Vector3(100, 100, 100);
	}
	
	// Update is called once per frame
	void Update () {

       // || OVRInput.Controller.Gamepad.Button.One;
       //Debug.Log("Trigger value r: " + Input.GetAxis("Xbox360RightTrigger"));
       //Debug.Log("Trigger value l: " + Input.GetAxis("Xbox360LeftTrigger"));


    }

    void FixedUpdate() {
        rightTrigger = Input.GetAxis("Xbox360RightTrigger");
        leftTrigger = Input.GetAxis("Xbox360LeftTrigger");
        Vector3 cameraPosition = Camera.main.gameObject.transform.forward;
        //rb.AddForce ((new Vector3(0, 20, 0) + cameraPosition) * speed * (rightTrigger - leftTrigger));

        Vector3 vForce = cameraPosition * speed * rightTrigger;
        Debug.Log("Force: " + vForce);
        rb.AddForce(vForce);

        rb.AddForce(-1 * rb.velocity * brakeCoef * leftTrigger);
        Debug.Log("Speed: " + rb.velocity.magnitude);
        rb.velocity = Vector3.Min(rb.velocity, maxSpeed);
    }
}
