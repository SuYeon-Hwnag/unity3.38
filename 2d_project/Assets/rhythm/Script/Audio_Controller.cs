using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_Controller : MonoBehaviour
{
    GameObject Audio;

    // Start is called before the first frame update
    void Start()
    {
        this.Audio = GameObject.Find("Audio");
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<ButtonTest>().start == true)
        {
            GetComponent<AudioSource>().Play();
        }
    }

    
}
