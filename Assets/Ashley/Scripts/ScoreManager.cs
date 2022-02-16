using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    //Box de texto
    public Text highscoreText;
    public Text counterText;
    //Variables
    public float Escore = 0;
    public int highscore = 0;

    private float timer = 0f;
    private float score;

    private void Awake()
    {
        MakeSingleton();
    }
    private void MakeSingleton()
    {
        if (Instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    void Start()
    {
        
    }
    void Update()
    {
        setCounter();
        if (Input.GetKeyDown("space")) //Aqui se va a poner la condición de que acaba una ronda. 
        {
            setScore();
        }

        setHighScore();
    }
    private void setScore()
    {
        score = timer;
        ScoreManager.Instance.Escore = score;
        timer = 0;
    }
    private void setCounter()
    {
        timer += Time.deltaTime;
        counterText.text = timer.ToString("f1");
    }

    private void setHighScore() {
        if (highscore < Escore)
        {
            highscoreText.text = "HighScore: " + Escore.ToString("f1");
        }
    }
}
