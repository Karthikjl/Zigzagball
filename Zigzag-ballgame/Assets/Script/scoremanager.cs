using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoremanager : MonoBehaviour
{


    public static scoremanager instance;
    public int score;
    public int highscore;


    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        PlayerPrefs.SetInt("score", score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void increment()
    {
        score += 1;
    }
    public void startscore()
    {
        InvokeRepeating ("increment", 0.1f, 0.5f);
    } 
    public void stopscore()
    {
        CancelInvoke("increment");

        PlayerPrefs.SetInt("score", score);

        if (PlayerPrefs.HasKey("highscore"))
        {
            if (score > PlayerPrefs.GetInt("highscore"))
            {
                PlayerPrefs.SetInt("highscore", score);
            }
           
        }
        else
        {
            PlayerPrefs.SetInt("highscore", score);
        }
    }
}
