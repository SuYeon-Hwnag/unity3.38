using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button_controller : MonoBehaviour
{
    GameObject Rbutton;
    GameObject Lbutton;
    GameObject Upbutton;
    GameObject Downbutton;

    public bool isrbutton = false;
    public bool islbutton = false;
    public bool isupbutton = false;
    public bool isdownbutton = false;

    float rTimer = 0.0f;
    float lTimer = 0.0f;
    float upTimer = 0.0f;
    float downTimer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        this.Rbutton = GameObject.Find("Rbutton");
        this.Lbutton = GameObject.Find("Lbutton");
        this.Upbutton = GameObject.Find("Upbutton");
        this.Downbutton = GameObject.Find("Downbutton");
    }

    // Update is called once per frame
    void Update()
    {
        if (isrbutton == true)
        {
            rTimer += Time.deltaTime;
            if (rTimer > 0.1f)
            {
                isrbutton = false;
                rTimer = 0;
            }
        }
        if (islbutton == true)
        {
            lTimer += Time.deltaTime;
            if (lTimer > 0.1f)
            {
                islbutton = false;
                lTimer = 0;
            }
        }
        if (isupbutton == true)
        {
            upTimer += Time.deltaTime;
            if (upTimer > 0.1f)
            {
                isupbutton = false;
                upTimer = 0;
            }
        }
        if (isdownbutton == true)
        {
            downTimer += Time.deltaTime;
            if (downTimer > 0.1f)
            {
                isdownbutton = false;
                downTimer = 0;
            }
        }
    }

    public void OnClickRbutton()
    {
        isrbutton = true;
        
    }
    public void OnClickLbutton()
    {
        islbutton = true;
        
    }
    public void OnClickUpbutton()
    {
        isupbutton = true;
        
    }
    public void OnClickDownbutton()
    {
        isdownbutton = true;
        
    }

}
