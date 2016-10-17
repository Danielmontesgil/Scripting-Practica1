using UnityEngine;
using System.Collections;

public class MoveEnemy : MonoBehaviour {

    private Rigidbody rb;
    

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }
	
	void Update ()
    {
        if (rb.velocity.magnitude <= 1)
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
}
