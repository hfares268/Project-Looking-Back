using UnityEngine;

public class HackyCharacterMover : MonoBehaviour {
    public Rigidbody myRigidbody;
    public float howMuchForce = 10f;
    
    void Update()
    {
        // Helloooooo
        if (Input.GetKeyDown(KeyCode.W)) {
            myRigidbody.AddForce(transform.forward *howMuchForce);
        }
        if (Input.GetKeyDown(KeyCode.A)) {
            myRigidbody.AddForce(-1 * transform.right *howMuchForce);
        }
        if (Input.GetKeyDown(KeyCode.S)) {
            myRigidbody.AddForce(-1 * transform.forward *howMuchForce);
        }
        if (Input.GetKeyDown(KeyCode.D)) {
            myRigidbody.AddForce(transform.right *howMuchForce);
        }
    }
}
