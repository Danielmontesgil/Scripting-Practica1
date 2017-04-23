using UnityEngine;
using System;
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

    public event Action punctuate;

    private int score;

    public int Score
    {
        get
        {
            return score;
        }
    }

    [SerializeField]
    private Text textScore;
    [SerializeField]
    private Text textTime;

    private float hitBall;

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

        textScore.text = "Score " + score;

        time = 10;
        textTime.text = "Time " + Mathf.Round(time);

        hitBall = 0;
    }

    private void Update()
    {
        time -= 1 * Time.deltaTime;
        textTime.text = "textTime " + Mathf.Round(time);
        if (time <= 0)
        {
            SceneManager.LoadScene("Perdiste");
        }

        if (hitBall == 2)
            SceneManager.LoadScene("Ganaste");
    }

    public void NotifyHit()
    {
        score++;
        textScore.text = "Score: " + score;
        hitBall++;
        if (punctuate != null)
            punctuate();
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
