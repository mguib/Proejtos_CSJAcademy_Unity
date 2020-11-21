using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtivarGameObjectComponente : MonoBehaviour
{
    public GameObject objeto;

    // Start is called before the first frame update
    void Start()
    {
        //objeto.SetActive(false);
        //objeto.GetComponent<BoxCollider2D>().enabled = false;
        
        if (objeto.activeSelf)
        {
            objeto.SetActive(false);
            Debug.Log(objeto.activeSelf);
        }
        else
        {
            objeto.SetActive(true);
            Debug.Log(objeto.activeSelf);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
