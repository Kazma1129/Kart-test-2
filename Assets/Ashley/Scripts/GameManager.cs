using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float HighScore;

    public static GameManager Instance;
    private void Awake()
    {
        MakeSingleton();
    }
    private void MakeSingleton()
    {
        if(Instance!= null)
        {
            Destroy(this.gameObject);
    }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
}
    private void HighScoreOp()
    {

    }
}
