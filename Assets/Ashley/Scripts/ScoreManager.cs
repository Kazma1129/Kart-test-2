using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    //Box de texto
    public Text highscoreText;
    public Text counterText;
    //Variables
    public float highscore = 0;
    public float timer = 0f;
    public float ClampTimer = 0f;
    public float currentScore;
    // public float escore;

    public bool plus= false;

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
        ClampTimer += Time.deltaTime;
        textCounter();
        if (Input.GetKeyDown("space")) //Aqui se va a poner la condición de que acaba una ronda. 
        {
            setScore();
        }
        timercomp();

    }

    //Lo que sucede cuando se da una vuelta. 
    private void setScore()
    {
        currentScore = timer;
        highScoreComparation();
        timer = 0;
    }

    //Esto siempre va a correr, setea el texto en pantalla
    private void textCounter()
    {
        timer += Time.deltaTime;
        counterText.text = timer.ToString("f1");
       

    }

    //Esto solo va a correr cuando se complete una vuelta
    private void highScoreComparation() {
        if (currentScore> highscore)
        {
            highscore = currentScore;
            highscoreText.text = "HighScore: " + highscore.ToString("f1");
        }
    }
    private void timercomp()
    {
        float redondeo = (int)ClampTimer;
        if ((redondeo/10)==1)
        {
            Debug.Log("Sijalo");
            plus = true;
        }
        else
        {
            plus = false;
        }
    }
}
