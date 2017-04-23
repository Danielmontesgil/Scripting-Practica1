using UnityEngine;
using System.Collections;

public class Apuntar : MonoBehaviour
{
    Vector3 lookPos;
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 100))
        {
            lookPos = hit.point;
        }

		Vector3 lookDir = lookPos -transform.position;
		lookDir.y = 0;

		transform.LookAt(transform.position + lookDir, Vector3.up);
    }

    void OnDrawGizmos()
    {
        Debug.DrawRay(transform.position, transform.forward);
    }
}