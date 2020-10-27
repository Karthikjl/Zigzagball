using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{
    public GameObject ball;
    Vector3 offset;
    [SerializeField]
    public float lerprate;
    public bool gameover;

    // Start is called before the first frame update
    void Start()
    {
        offset = ball.transform.position - transform.position;
        gameover = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameover)
        {
            follow();
        }
    }
    void follow()
    {
        Vector3 pos = transform.position;
        Vector3 targetpos = ball.transform.position - offset;
        pos = Vector3.Lerp( pos,targetpos, lerprate * Time.deltaTime);
        transform.position = pos; 

    }
}
