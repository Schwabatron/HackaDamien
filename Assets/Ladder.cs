using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour
{

    private float vertical; //Making sure the only direction you move on the ladder is vertical
    [SerializeField] private float speed = 8f; //How fast you move up the ladder
    private bool next_to_ladder; //Boolean to detect if the player is in the range of a ladder
    private bool onLadder; //Boolean to check if the player is currently ON a ladder 
    [SerializeField] private Rigidbody2D rb; //Serialized field for the rigidBody 

    
    //Method that is called automatically when a 2D collider enters the trigger collider attached to a GameObject
    //Param: represents the Collider2D of the other GameObject that entered the trigger collider
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Checking if the collison occured on the Ladder 
        if(collision.CompareTag("Ladder"))
        {
            next_to_ladder = true;
        }
    }
    //Method automatically called when a 2d colliden attached to a gameobject exits another collider 
    private void OnTriggerExit2D(Collider2D collision)
    {
        //Checking if the exit occured on the Ladder 
        if(collision.CompareTag("Ladder"))
        {
            next_to_ladder = false;
            onLadder = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxis("Vertical");

        if(next_to_ladder && Mathf.Abs(vertical)>0f)
        {
            onLadder = true;
        }
    }

    private void FixedUpdate()
    {
        if(onLadder == true)
        {
            rb.gravityScale = 0f;
            rb.velocity = new Vector2(rb.velocity.x, vertical * speed);
        }
        else
        {
            rb.gravityScale = 2f;
        }
    }
}
