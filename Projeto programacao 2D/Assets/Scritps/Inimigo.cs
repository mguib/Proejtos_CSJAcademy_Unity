using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    public int health = 100;
    public void Damage(int damagValue)
    {
        health -= damagValue;
    }


    //Possibilita este metodo ser reescrito por classes herdadas
    public virtual void Attack()
    {

    }
}
