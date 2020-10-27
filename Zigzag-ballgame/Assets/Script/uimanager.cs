using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class uimanager : MonoBehaviour
{

    public static uimanager instance;

    public GameObject zigzagpanal;
    public GameObject gameoverpanal;
    public GameObject taptext;
    public Text score;
    public Text highscore1;
    public Text highscore2;


    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }


    }


    void Start()
    {
        highscore1.text = "High Score - " + PlayerPrefs.GetInt("highscore");
    }

    public void gamestart()
    {
       
        taptext.SetActive(false);
        zigzagpanal.GetComponent<Animator>().Play("panalzigzag");


    }

    public void gameover()
    {
        score.text = PlayerPrefs.GetInt("score").ToString();
        highscore2.text = PlayerPrefs.GetInt("highscore").ToString();
        gameoverpanal.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
