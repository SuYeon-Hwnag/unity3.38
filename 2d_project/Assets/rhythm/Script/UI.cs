using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UI : MonoBehaviour
{
    GameObject Hp;
    // Start is called before the first frame update
    void Start()
    {
        this.Hp = GameObject.Find("Hp");
    }

    // Update is called once per frame
    void Update()
    {
        // if(ArrowGenerator<-5.8)
    }
    public void DecreaseHp()
    {
        this.Hp.GetComponent<Image>().fillAmount -= 0.1f;
        if (this.Hp.GetComponent<Image>().fillAmount <= 0)
        {
            SceneManager.LoadScene("EndScene");
        }
    }
}
