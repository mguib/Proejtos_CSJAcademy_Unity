using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : Inimigo
{
    // Start is called before the first frame update
    void Start()
    {
        Attack();
    }

    //Reescreve o método Attack da classe heradada inimigo
    public override void Attack()
    {
        base.Attack();
    }
}
