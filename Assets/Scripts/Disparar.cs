using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Disparar : MonoBehaviour
{

    [SerializeField]
    private GameObject aimLine;
    [SerializeField]
    private Scrollbar strengthBar;

    public static bool withStrength;

    private float strength;
    private bool isStill;
    private bool canGetStrength;
    private Rigidbody rb;

    void Awake()
    {
        canGetStrength = true;
        isStill = false;
        withStrength = false;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (rb.velocity.magnitude <= 1)
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            if (isStill)
            {
                transform.rotation = (new Quaternion(0, 0, 0, 0));
                isStill = false;
            }
            if (Input.GetMouseButtonDown(0))
            {
                strength = 0;
            }
            if (Input.GetMouseButton(0))
            {
                ballStrength();
            }
            if (Input.GetMouseButtonUp(0))
            {
                shotBall();
                aimLine.SetActive(false);
            }
            else
                aimLine.SetActive(true);
        }

        strengthBar.GetComponent<Scrollbar>().size = strength / 60;
    }

    void ballStrength()
    {
        while (canGetStrength)
        {
            strength += 30 * Time.deltaTime;

            if (strength >= 60)
                canGetStrength = false;
            break;
        }
        while (!canGetStrength)
        {
            strength -= 30 * Time.deltaTime;
            if (strength <= 0)
                canGetStrength = true;
            break;
        }
    }

    void shotBall()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * strength, ForceMode.Impulse);
        isStill = true;
    }
}
