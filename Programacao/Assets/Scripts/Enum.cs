using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enum : MonoBehaviour
{
    public enum direcoes
    {
        norte,
        sul, 
        leste,
        oeste
    }

    public direcoes minhaDirecao;

    // Start is called before the first frame update
    void Start()
    {
        switch (minhaDirecao)
        {
            case direcoes.norte:
                DirecaoSelecionada("Norte Selecionado");
                return;
            case direcoes.sul:
                DirecaoSelecionada("Sul selecionada");
                return;
            case direcoes.oeste:
                DirecaoSelecionada("Oeste selecionada");
                return;
            case direcoes.leste:
                DirecaoSelecionada("Leste selecionada");
                return;
        }   
    }

    void DirecaoSelecionada(string texto)
    {
        Debug.Log(texto);
    }
}
