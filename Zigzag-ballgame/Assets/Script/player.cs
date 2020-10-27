using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public GameObject partical;

    [SerializeField]
    public float speed;

    Rigidbody rb;

    bool started;
    bool gameover;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Start()
    {
        started = false;
        gameover = false;
    }


    void Update()
    {
        if (!started) 
        {
            if (Input.GetMouseButtonDown(0))
            {
                rb.velocity = new Vector3(speed, 0, 0);
                started = true;
                gamemanager.instance.startgame();


            }
        }

        if (!Physics.Raycast(transform.position, Vector3.down, 1f))
        {
            gameover = true;
            rb.velocity = new Vector3(0, -25f, 0);

            Camera.main.GetComponent<camara>().gameover = true;
            gamemanager.instance.Gameover();
        }

        if (Input.GetMouseButtonDown(0) && !gameover)
        {
            switchdirection();
        }
    }
    void switchdirection()
    {
        if(rb.velocity.z > 0)
        {
            rb.velocity = new Vector3(speed, 0, 0);
        }
        else if (rb.velocity.x > 0)
        {
            rb.velocity = new Vector3(0, 0, speed);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "diamond")
        {
            GameObject part = Instantiate(partical, other.gameObject.transform.position, Quaternion.identity) as GameObject;
            Destroy(other.gameObject);
            Destroy(part, 1f);
           
        }
    }

}
