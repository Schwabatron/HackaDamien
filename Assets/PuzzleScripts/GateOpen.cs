using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateOpen : MonoBehaviour
{
    private bool active = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void activate()
    {
        Debug.Log("active");
        active = true;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Capsule") && active)
        {
            //get rid of capsule and delete gate
            Destroy(collision.gameObject);
            Destroy(GameObject.Find("Gate"));
        }
    }
}
