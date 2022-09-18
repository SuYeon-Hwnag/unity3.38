using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class left_arrow_controller : MonoBehaviour
{
    GameObject Lbutton;
    // Start is called before the first frame update
    void Start()
    {
        this.Lbutton = GameObject.Find("Lbutton");
    }

    // Update is called once per frame
    void Update()
    {
        // transform.Translate(0, -0.1f, 0); // 떨어짐

        transform.Translate(Vector3.down * 0.1f); //-> 화살표 모양 기준 아래방향

        if (this.transform.position.y > -5.0f && this.transform.position.y < -3.75f && GameObject.Find("GameDirector").GetComponent<button_controller>().islbutton)
        {
            // 점수 올라감

            // 닿으면 사라짐
            Destroy(gameObject);
        }

        // 떨어짐
        if (this.gameObject.transform.position.y < -5.7)
        {
            GameObject UI = GameObject.Find("Hp");
            UI.GetComponent<UI>().DecreaseHp();

            Destroy(gameObject); // 닿으면 사라짐
        }

    }

}