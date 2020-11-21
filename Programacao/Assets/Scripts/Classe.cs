using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Classe : MonoBehaviour
{
    //Classe
    [System.Serializable]
    public class Cachorro
    {
        //Atributos
        public string raca;
        public int idade;
        public int tamanho;

        //Construtor
        public Cachorro(string Raca, int Idade, int Tamnho)
        {
            raca = Raca;
            idade = Idade;
            tamanho = Tamnho;
        }
    }

    //Criação de um objeto da classe Cachorro
    public Cachorro Dog = new Cachorro("Pitibull", 5, 80);
    private void Start()
    {
        //Debug.Log(Dog.raca);

        Estaticos.estaticos.AumentearVida();
        Debug.Log("Total de vidas é: " + Estaticos.estaticos.vidas);
    }
}
