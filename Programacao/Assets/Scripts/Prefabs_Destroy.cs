using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prefabs_Destroy : MonoBehaviour
{
    public GameObject gameObject;
    public GameObject pai;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Instantiate(gameObject, pai.transform.position, pai.transform.rotation);
        }
        
    }
}
