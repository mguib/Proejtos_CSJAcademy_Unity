using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float tempoSpawner = 5f;
    public List<GameObject> Paredes =  new List<GameObject>();
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    float tempoCont;
    // Update is called once per frame
    void Update()
    {
        tempoCont += Time.deltaTime;

        if (tempoCont >= tempoSpawner)
        {
            Instantiate(Paredes[Random.Range(0, Paredes.Count)], transform.position, transform.rotation);

            tempoCont = 0f;
        }
    }
}
