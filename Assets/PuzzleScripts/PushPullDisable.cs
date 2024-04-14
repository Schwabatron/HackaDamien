using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushPullDisable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Box1"))
        {
            //stop letting player push/pull box
            GameObject.Find("Player").GetComponent<PushPull>().Disable();

            //set position of box
            gameObject.transform.position = new Vector2(15.4f, -1.33f);
            gameObject.transform.rotation = Quaternion.identity;

            //make it so crate doesn't have physics
            Destroy(gameObject.GetComponent<Rigidbody2D>());
            Destroy(collision.gameObject.GetComponent<Box1Push>());

            //allow pickup of capsule
            GameObject.Find("Player").GetComponent<GateOpen>().activate();
        }
    }
}
