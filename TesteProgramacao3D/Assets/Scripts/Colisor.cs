using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisor : MonoBehaviour
{
    private Rigidbody rig;
    public float velocidade;
    public float forcaPulo;
    private bool estaNoChao;

    private void Start() {
        rig = GetComponent<Rigidbody>();
    }

    void Update() {
        if(Input.GetKey(KeyCode.LeftArrow)){
            rig.AddForce(Vector3.left * velocidade * Time.deltaTime, ForceMode.Acceleration);
        }

        if(estaNoChao && Input.GetKey(KeyCode.Space)){
            rig.AddForce(Vector3.up * forcaPulo, ForceMode.Impulse);
            estaNoChao = false;
        }
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.layer == 8){
            estaNoChao = true;
        }
    }
}
 