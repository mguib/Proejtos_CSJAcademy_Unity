using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POO : MonoBehaviour
{
    public class Personagem
    {
        //Caracteristicas do objeto
        float vida;
        float poder;
        float exp;

        //Comportamentos do objeto
        void aumentarVida()
        {
            
        }

        public Personagem( float xp)
        {
            exp = xp;
        }
    }

    Personagem p1 = new Personagem(50f);

}
