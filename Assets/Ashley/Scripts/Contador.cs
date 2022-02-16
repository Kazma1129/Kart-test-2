using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contador : MonoBehaviour
{
    public Text counter;


    private float timer=0f;
    private float score;
    private bool stop = false;
    private void Start()
    {
        counter = GetComponent<Text>();
    }
    private void Update()
    {
        setCounter();
        if (Input.GetKeyDown("space")) //Aqui se va a poner la condición de que acaba una ronda. 
        {
            setScore();
        }
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
        counter.text = timer.ToString("f1");
    }
}
