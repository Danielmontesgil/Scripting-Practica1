using UnityEngine;
using System.Collections;

public class ActivarPowerUp : MonoBehaviour {



	private void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.CompareTag("Player"))
        {
            c.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            c.gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            c.gameObject.transform.position = new Vector3(0f, 0.5f, -7.78f);
            Disparar.conPoder = true;
        }
    }
}
