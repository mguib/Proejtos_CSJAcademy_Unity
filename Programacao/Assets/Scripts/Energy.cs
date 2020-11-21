using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Energy : MonoBehaviour
{
    public float speed;
    
    private SpriteRenderer spritePlayer;
    private Player player;
    private bool direction;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        spritePlayer = player.GetComponent<SpriteRenderer>();
        direction = spritePlayer.flipX;

        Destroy(gameObject, 4f);
    }

    // Update is called once per frame
    void Update()
    {
        if(direction){
            transform.Translate(Vector2.left * Time.deltaTime * speed);   
        }else{
            transform.Translate(Vector2.right * Time.deltaTime * speed);   
        }
        
    }
}
