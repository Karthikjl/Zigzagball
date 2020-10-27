using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plartformspawner : MonoBehaviour
{
    public GameObject plartform;
    public GameObject diamond;

    Vector3 lastpos;
    float size;
    public bool gameover;



    // Start is called before the first frame update
    void Start()
    {
        lastpos = plartform.transform.position;
        size = plartform.transform.localScale.x;
        for(int i = 0; i < 20; i++)
        {
            spawnplartform();
        }
        
    }

    public void startspawningplartform()
    {
        InvokeRepeating("spawnplartform", 0.1f, 0.2f);
    }


    // Update is called once per frame
    void Update()
    {
        if (gamemanager.instance.gameover == true)
        {
            CancelInvoke("spawnplartform");
        }
    }

    void spawnplartform()
    {
        int rand = Random.Range(0, 6);
        if (rand < 3)
        {
            spawnx();
        }
        else if (rand >= 3)
        {
            spawnz();
        }
    }


    void spawnx()
    {
        Vector3 pos = lastpos;
        pos.x += size;
        lastpos = pos;
        Instantiate(plartform, pos, Quaternion.identity);

        int rand = Random.Range(0, 4);
        if (rand < 1)
        {
            Instantiate(diamond, new Vector3(pos.x, pos.y + 1, pos.z),diamond.transform.rotation);
        }




    }
    void spawnz()
    {
        Vector3 pos = lastpos;
        pos.z += size;
        lastpos = pos;
        Instantiate(plartform, pos, Quaternion.identity);

        int rand = Random.Range(0, 4);
        if (rand < 1)
        {
            Instantiate(diamond, new Vector3(pos.x, pos.y + 1, pos.z), diamond.transform.rotation);
        }
    }
}
