using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManCharacter : Polimorfismo
{
    // Start is called before the first frame update
    void Start()
    {
        Say();
    }

    public override void Say()
    {
        Debug.Log("Salve meu consagrado!, Firmeza?");
    }
}

    
