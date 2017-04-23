using UnityEngine;
using System.Collections;

public class DestroyEnemy : MonoBehaviour {

    private void Start()
    {
        GameManager.Instance.punctuate += DebugPuntuar;
    }

    private void DebugPuntuar()
    {
        Debug.Log("Destruiste un enemigo");
    }

    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.CompareTag("Player"))
        {
            if (Disparar.withStrength)
            {
                Destroy(gameObject);
                GameManager.Instance.NotifyHit();
            }
        }
    }
}
