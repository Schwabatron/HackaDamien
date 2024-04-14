using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BounceFix : MonoBehaviour
{
    // Start is called before the first frame update

    private Vector2 PrevPosition;
    void FixedBounce()
    {
        PrevPosition = transform.position;
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D c)
    {
        transform.position = PrevPosition;
    }
}
