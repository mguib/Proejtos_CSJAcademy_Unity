using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    int[] inimigos;
    string[] nomes;
    public GameObject[] player;
    Transform[] transforms;

    // Start is called before the first frame update
    void Start()
    {
        //Essa função buscar os objetos que estão na cena e possuem a tag Player
        //para armazenar no array de GameObjects
        player = GameObject.FindGameObjectsWithTag("Player");

        //Primeira forma de como percorrer um array (mais eficaz)
        //foreach (GameObject p in player)
        //{
        //    Debug.Log(p.name);
        //}

        //Outra forma de percorrer arrays
        for (int i = 0; i < player.Length; i ++)
        {            
            Debug.Log(player[i].name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
