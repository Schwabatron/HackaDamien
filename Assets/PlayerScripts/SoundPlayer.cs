using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    private AudioSource musicComp;
    private string musicClipPath;

    // Start is called before the first frame update
    void Start()
    {
        musicComp = GetComponent<AudioSource>();
        musicComp.loop = true;
        musicComp.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
