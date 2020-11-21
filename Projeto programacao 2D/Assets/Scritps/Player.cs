using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int velocidade;
    public int forcaPulo;
    public int vida;

    private Rigidbody2D rig;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rig.velocity = new Vector2(velocidade, rig.velocity.y);

        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Space))
        {
            rig.velocity = new Vector2(rig.velocity.x, forcaPulo);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Vida")
        {
            vida ++;
            Debug.Log("Colidiu na vida");
            Destroy(collision.gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Espinho")
        {
            vida--;
            Debug.Log("Colidiu no espinho");
        }
    }
}
