using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager : MonoBehaviour
{


    public static gamemanager instance;
    public bool gameover;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        gameover = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void startgame()
    {
        uimanager.instance.gamestart();
        scoremanager.instance.startscore();
        GameObject.Find("plartformspawner").GetComponent<plartformspawner>().startspawningplartform();
    }
    public void Gameover()
    {
        uimanager.instance.gameover();
        scoremanager.instance.stopscore();
        gameover = true;
    }
}
