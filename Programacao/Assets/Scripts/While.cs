using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class While : MonoBehaviour
{
    int itensCena = 5;
    int dinheiro = 500;

    // Start is called before the first frame update
    void Start()
    {
        //while (itensCena > 0)
        //{
        //    Debug.Log("Executando while" + itensCena);
        //    itensCena--;
        //}

        do
        {
            Debug.Log("Seu dinheiro é: " + dinheiro);
            dinheiro += 50;
        } while (dinheiro < 2000);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
