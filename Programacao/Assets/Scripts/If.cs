using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If : MonoBehaviour
{
    private bool saldo;
    string compras = "";
    public int n1;

    // Start is called before the first frame update
    void Start()
    {
        if (n1 > 0)
        {
            compras = "Número positivo";
            Debug.Log(compras);
        }
        else if(n1 < 0)
        {
            compras = "Número negativo";
            Debug.Log(compras);
        }
        else
        {
            Debug.Log("O número é zero!");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
