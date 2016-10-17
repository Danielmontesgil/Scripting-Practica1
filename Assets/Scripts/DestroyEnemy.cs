using UnityEngine;
using System.Collections;

public class DestroyEnemy : MonoBehaviour {

    private void Start()
    {
        GameManager.Instance.Puntuar += DebugPuntuar;
    }

    private void DebugPuntuar()
    {
        Debug.Log("Destruiste un enemigo");
    }

    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.CompareTag("Player"))
        {
            if (Disparar.conPoder)
            {
                Destroy(gameObject, 3);
                GameManager.Instance.NotifyHit();
            }
        }
    }
}
