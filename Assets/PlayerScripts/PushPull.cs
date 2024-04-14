using System;
using System.Collections.Generic;
using UnityEngine;

public class PushPull : MonoBehaviour
{
    private Rigidbody2D otherRb;
    [SerializeField] private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Crate") && Input.GetKey(KeyCode.J) && Input.GetKey(KeyCode.A))
        {
            otherRb.transform.position = Vector2.MoveTowards(otherRb.transform.position, rb.transform.position, 50);
            otherRb.transform.position = new Vector3(otherRb.transform.position.x - 2, otherRb.transform.position.y, 0);
            otherRb.constraints = RigidbodyConstraints2D.None;
        }
        else if (collision.gameObject.name.Equals("Crate") && Input.GetKey(KeyCode.J) && Input.GetKey(KeyCode.D))
        {
            otherRb.transform.position = Vector2.MoveTowards(otherRb.transform.position, rb.transform.position, 50);
            otherRb.transform.position = new Vector3(otherRb.transform.position.x + 2, otherRb.transform.position.y, 0);
            otherRb.constraints = RigidbodyConstraints2D.None;
        }
        else if (collision.gameObject.name.Equals("Crate"))
        {
            otherRb.constraints = RigidbodyConstraints2D.FreezePosition;
        }

    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Crate"))
        {
            otherRb.velocity = new Vector2(0, otherRb.velocity.y);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Crate"))
        {
            otherRb = collision.gameObject.GetComponent<Rigidbody2D>();
        }
    }
}