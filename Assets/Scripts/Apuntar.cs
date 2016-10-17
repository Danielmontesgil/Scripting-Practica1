using UnityEngine;
using System.Collections;

public class Apuntar : MonoBehaviour {

	float velocidadHorizontal=15f;
	float h;

	// Update is called once per frame
	void Update()
	{
		h = velocidadHorizontal * Input.GetAxis("Mouse X");
		transform.Rotate(0, h, 0);
	}

	void OnDrawGizmos() {
		Debug.DrawRay (transform.position,transform.forward);
	}
}