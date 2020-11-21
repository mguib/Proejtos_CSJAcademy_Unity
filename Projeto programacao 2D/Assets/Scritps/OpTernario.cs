using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpTernario : MonoBehaviour
{
    public int life;
    // Start is called before the first frame update
    void Start()
    {
        //Operador ternário é usado para atribuição, é necessário que ele seja
        //atribuido alguma variável
        Debug.Log( life > 0 ? "Player vivo!" : "Player morto!");
        
    }

    
}
