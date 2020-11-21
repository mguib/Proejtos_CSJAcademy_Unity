using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emcapsulamento : MonoBehaviour
{

    /* Encapsulamos com sucesso o valor Vidas privado e ao fazer isso,
     protegemos o Warrior de ter uma vida menor que zero*/
    public class Warrior
    {
        private int vida;

        public int Health
        {
            get
            {
                return vida;
            }

            set
            {
                vida -= value;

                if (vida >= 0)
                {
                    vida = 0;
                    //Destroy personagem
                    Die();
                }
            }
        }

        private void Die()
        {
            //Ação a ser realiza depois que o personagem morrer
        }
    }
}
