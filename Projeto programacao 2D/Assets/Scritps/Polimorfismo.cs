using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Polimorfismo : MonoBehaviour
{
    //é o principio pelo qual duas ou mais classes derivadas de uma mesma classe
    //base podem invocar m´todos que tem a mesma assinatura, porem comportamenteos
    //distintos

    public string name;
    public int Health;
    public int Strength;
    public float speed;

    public virtual void Say()
    {
        Debug.Log("Olá, amigo!");
    }
}
