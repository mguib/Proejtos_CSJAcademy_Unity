using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player2 player1 = new Player2();
        //player1.Experience = 10;
        //Debug.Log(player1.Experience);

        //player1.Life = 10;
        //Debug.Log(player1.Life);

        //player1.Lives = 10;
        //Debug.Log(player1.Lives);

        Sobrecarga sob = new Sobrecarga();
        sob.Add(10,20);
        sob.Add("Marcos", "Guibson");
    }

    
}
