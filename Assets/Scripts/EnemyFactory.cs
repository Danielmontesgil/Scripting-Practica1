using UnityEngine;
using System.Collections;

public class EnemyFactory : MonoBehaviour {

    [SerializeField]
    private GameObject enemyTemplate;

    public GameObject BuildEnemy()
    {
        GameObject instance = Instantiate(enemyTemplate);
        ApplyColor(instance);
        return instance;
    }

    private void ApplyColor(GameObject car)
    {
        Renderer carRenderer = car.GetComponent<Renderer>();
        carRenderer.material.color = GetRandomColor();
    }

    private Color GetRandomColor()
    {
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        Color color = new Color(r, g, b, 1f);
        return color;
    }
}

