using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    int diaSemana = 3;

    // Start is called before the first frame update
    void Start()
    {
        //Para sair do Loop pode ser usado return ou break
        switch (diaSemana)
        {
            case 1:
                Debug.Log("Domingo");
                return;
            case 2:
                Debug.Log("Segunda");
                return;
            case 3:
                Debug.Log("Terça");
                return;
            default:
                Debug.Log("Fora de Data!");
                return;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
