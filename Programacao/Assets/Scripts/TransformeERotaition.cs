using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformeERotaition : MonoBehaviour
{

    public float velocidade;
    public float rotacao;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //Debug.Log("Vaii");
            transform.Translate(new Vector2(0,1) * velocidade * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //Debug.Log("Vaii");
            transform.Translate(new Vector2(0, -1) * velocidade * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector2(0,1) * rotacao * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector2(0,-1) * rotacao * Time.deltaTime);
        }

    }
}
