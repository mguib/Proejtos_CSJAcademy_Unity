using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estaticos : MonoBehaviour
{
    public static Estaticos estaticos;
    public int vidas = 3;
    // Start is called before the first frame update
    void Start()
    {
        estaticos = this;
    }

    public void AumentearVida()
    {
        Debug.Log(vidas);
    }
}
