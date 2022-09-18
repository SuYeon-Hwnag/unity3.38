using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonTest : MonoBehaviour
{
    public bool start = false;
    public AudioSource audiosource;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BtnTestFunction()
    {
        SceneManager.LoadScene("GameScene");
        audiosource.Play();
        start = true;
    }


}
