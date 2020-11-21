using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foreach : MonoBehaviour
{
    string[] inimigos = new string [3];

    // Start is called before the first frame update
    void Start()
    {
        inimigos[0] = "Inimigo 1";
        inimigos[1] = "Inimigo 2";
        inimigos[2] = "Inimigo 2";

        //So pode ser utilizado em arrays
        foreach (string ini in inimigos)
        {
            Debug.Log(ini);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
