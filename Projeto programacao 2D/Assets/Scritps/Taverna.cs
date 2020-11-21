using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Taverna : MonoBehaviour
{
    public Polimorfismo[] chars;

    // Start is called before the first frame update
    void Start()
    {
        chars = new Polimorfismo[2];

        chars[0] = new ManCharacter();
        chars[1] = new OrcCharacter();

        EnterTaverna();
    }

    public void EnterTaverna()
    {
        foreach (Polimorfismo c in chars){
            c.Say();
        }
    }

   
}
