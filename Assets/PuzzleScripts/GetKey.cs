using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GetKey : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //whenever you collide with something
    void OnCollisionEnter2D(Collision2D collision)
    {
        //if you touch key
        if (collision.gameObject.name.Equals("Key"))
        {

            GameObject Rocks = GameObject.Find("RockWall");
            SpriteRenderer srRocks = Rocks.GetComponent<SpriteRenderer>();
            srRocks.sortingLayerName = "tree";
            //remove the key
            Destroy(collision.gameObject);

            //create ladder and add components
            GameObject ladder = new GameObject("ladder");

            ladder.tag = "Ladder";

            //create SpriteRenderer and add to ladder
            SpriteRenderer sr = new SpriteRenderer();
            sr = ladder.AddComponent<SpriteRenderer>();
            

            //create boxcollider2d and add to ladder as well as configure
            BoxCollider2D bc = new BoxCollider2D(); 
            bc = ladder.AddComponent<BoxCollider2D>();
            //bc config
            bc.isTrigger = true;
            bc.size = new Vector2(.7f, .65f);
            //set ladder sprite as a square
            Texture2D texture = new Texture2D(64, 64);
            sr.sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.one * 0.5f);

            //setup ladder size and position
            ladder.transform.position = new Vector2(10, 0);
            ladder.transform.localScale = new Vector2(1, 6);

        }
    
    }
}
