using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public float startTimeAttack;
    public Transform point;
    public Transform backPoint;
    public GameObject energy;


    private float timeAttack;
    private Rigidbody2D rig;
    private Animator anim;
    private SpriteRenderer sprite;
    private bool isGrounded;



    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    bool isAtk;
    private void FixedUpdate() {
        if(Input.GetKey(KeyCode.LeftArrow) && !isAtk){
            rig.velocity = new Vector2(-speed, rig.velocity.y);
            anim.SetBool("isWalking", true);
            sprite.flipX = true;
        }else{
            rig.velocity = new Vector2(0, rig.velocity.y);
            anim.SetBool("isWalking", false);
        }

        if(Input.GetKey(KeyCode.RightArrow) && !isAtk){
            rig.velocity = new Vector2(speed, rig.velocity.y);
            anim.SetBool("isWalking", true);
            sprite.flipX = false;
        }

        if(Input.GetKeyDown(KeyCode.UpArrow) && isGrounded){
            rig.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isGrounded = false;
            anim.SetBool("isJumping", true);
        }

        if(timeAttack <= 0){
            isAtk = false;
            if(Input.GetKeyDown(KeyCode.Z)){
                //anim.SetTrigger("isAttacking");
                anim.SetBool("isAtk", true);
                timeAttack = startTimeAttack;
                isAtk = true;
                
            }

            
        }else{
            timeAttack -= Time.deltaTime;
            //anim.SetTrigger("isAttacking");
            anim.SetBool("isAtk", false);
        }

        anim.SetBool("isAtk", isAtk);

        if(Input.GetKeyDown(KeyCode.X)){
            GameObject bullet = Instantiate(energy);
            AudioController.current.PlayMusic(AudioController.current.anotherSfx);
            if(!sprite.flipX){
                bullet.transform.position = point.transform.position;
            }else{
                bullet.transform.position = backPoint.transform.position;
            }
            
        }
    }

    private void OnCollisionEnter2D(Collision2D coll) {
        if(coll.gameObject.layer == 8){
            isGrounded = true;
            anim.SetBool("isJumping", false);
        }

        if(coll.gameObject.tag == "Enemy"){
            coll.gameObject.GetComponent<Animator>().SetTrigger("hit");
            Destroy(coll.gameObject, 1f);
            rig.AddForce(Vector2.up  * jumpForce , ForceMode2D.Impulse);
            AudioController.current.PlayMusic(AudioController.current.sfx);
        }
    }
}
