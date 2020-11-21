using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metodo : MonoBehaviour
{
    public int vida;
    public int valorDano;

    // Start is called before the first frame update
    void Start()
    {
        DiminuirVida(valorDano);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DiminuirVida( int dano)
    {
        vida -= dano;
    }
}
