using UnityEngine;
using System;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    public static GameManager Instance
    {
        get
        {
            return instance;
        }
    }

    public event Action Puntuar;

    private int score;

    public int Score
    {
        get
        {
            return score;
        }
    }

    [SerializeField]
    private Text text;
    [SerializeField]
    private Text tiempo;

    private float pipo;

    private float time;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
        
        text.text = "Score " + score;

        time = 50;
        tiempo.text = "Tiempo " + time;

        pipo = 0;
    }

    private void Update()
    {
        time -= 1 * Time.deltaTime;
        tiempo.text = "Tiempo " + time;
        if (time <= 0)
        {
            SceneManager.LoadScene("Perdiste");
        }

        if(pipo==2)
            SceneManager.LoadScene("Ganaste");
    }

    public void NotifyHit()
    {
        score++;
        text.text = "Score: " + score;
        pipo++;
        if (Puntuar != null)
            Puntuar();
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
