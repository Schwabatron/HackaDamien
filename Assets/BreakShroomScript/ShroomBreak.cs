using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShroomBreak : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Crate")
        {
            Destroy(gameObject);
        }
        
    }
}
