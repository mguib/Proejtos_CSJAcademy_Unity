using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetComponentes : MonoBehaviour
{
    private Rigidbody2D rig;
    private BoxCollider2D box;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        box = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
