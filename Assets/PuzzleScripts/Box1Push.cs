using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box1Push : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.right * 2000, ForceMode2D.Force);
    }
}
