using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMovement : MonoBehaviour{

    [SerializeField] private float jumpingPower = 16f;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed = 8f;

    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update(){
        float horizontal = Input.GetAxisRaw("Horizontal");
        bool jumping = false;
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);

        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W)) && jumping == false){
            rb.AddForce(Vector2.up * jumpingPower, ForceMode2D.Impulse);
            jumping = true;
        }
        if (rb.velocity.y = 0f){
            jumping = false;
        }
    }
}
