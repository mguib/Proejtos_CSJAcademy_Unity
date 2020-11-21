using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKeyMouse : MonoBehaviour
{
    private void OnMouseDown()
    {
        Debug.Log("Clicou");
    }

    private void OnMouseDrag()
    {
        Debug.Log("Arrasta");
    }

    private void OnMouseEnter()
    {
        Debug.Log("Visualisou");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Tecla A pressionada");
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("Tecla B pressionada");
        }

        if (Input.GetKeyUp(KeyCode.C))
        {
            Debug.Log("Tecla C pressionada");
        }
        
    }
}
