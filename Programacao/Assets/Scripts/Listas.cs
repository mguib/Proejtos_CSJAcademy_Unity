using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Listas : MonoBehaviour
{
    [System.Serializable]
    public class Inimigo
    {
        public string name;
        public int velocidade;
        public int dano;

        public Inimigo(string nome, int v, int d)
        {
            name = nome;
            velocidade = v;
            dano = d;
        }
    }

    private void Start()
    {
        inimigos.Add(new Inimigo("Inimigo x",20,5)) ;
        inimigos.Add(new Inimigo("Inimigo y",50,20));
    }

    public List<Inimigo> inimigos = new List<Inimigo>();

}
