using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PegarItem : MonoBehaviour
{
    public int pontucao = 0;

    public Text pontCont;

    private void Update() {
        pontCont.text = "x " + pontucao.ToString();
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Moeda"){
            pontucao +=10;
            Destroy(other.gameObject);
        }
    }
}
