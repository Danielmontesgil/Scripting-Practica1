using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Disparar : MonoBehaviour {

    public static bool conPoder;

	private float fuerza;
    private bool parar;
	private bool sube;
	public Scrollbar myScroll;
    private Rigidbody rb;

    void Awake()
    {
        conPoder = false;
    }

	// Use this for initialization
	void Start ()
	{
		sube = true;
        rb = GetComponent<Rigidbody>();
        parar = false;
    }
	
	// Update is called once per frame
	void Update ()
	{
        if (rb.velocity.magnitude <= 1) {
            rb.velocity = Vector3.zero;
            rb.angularVelocity=Vector3.zero;
            if (parar)
            {
                transform.rotation = (new Quaternion(0, 0, 0, 0));
                parar = false;
            }
            if (Input.GetMouseButtonDown(0))
            {
                fuerza = 0;
            }
            if (Input.GetMouseButton(0))
            {
                while (sube)
                {
                    fuerza += 20 * Time.deltaTime;

                    if (fuerza >= 60)
                        sube = false;
                    break;
                }
                while (!sube)
                {
                    fuerza -= 20 * Time.deltaTime;
                    if (fuerza <= 0)
                        sube = true;
                    break;
                }
            }
            if (Input.GetMouseButtonUp(0))
            {
                GetComponent<Rigidbody>().AddForce(transform.forward * fuerza, ForceMode.Impulse);
                parar = true;
            }
        }
		myScroll.GetComponent<Scrollbar> ().size = fuerza / 60;
	}
}
