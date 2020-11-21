using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parede : MonoBehaviour
{
    public float velocidade;

    private void Start()
    {
        Destroy(gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-Vector3.forward * velocidade * Time.deltaTime);
    }
}
