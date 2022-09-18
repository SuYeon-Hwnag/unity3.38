using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class down_arrow_controller : MonoBehaviour
{
    GameObject Downbutton;
    // Start is called before the first frame update
    void Start()
    {
        this.Downbutton = GameObject.Find("Downbutton");
    }

    // Update is called once per frame
    void Update()
    {
        // transform.Translate(0, -0.1f, 0); // 떨어짐

        transform.Translate(Vector3.down * 0.1f); //-> 화살표 모양 기준 아래방향

        // 충돌 판정
        /*
        Vector2 p1 = transform.position; // 화살 중심 좌표
        Vector2 p2 = this.Downbutton.transform.position; // 버튼 중심 좌표
        Vector2 dir = p1 - p2;
        float d = dir.magnitude; // 벡터 길이 
        float r1 = 0.5f; // 화살 반경
        float r2 = 0.5f; // 버튼 반경
        Debug.Log(d);
        Debug.Log("jjj");
        */

        if (this.transform.position.y > -5.0f && this.transform.position.y < -3.75f && GameObject.Find("GameDirector").GetComponent<button_controller>().isdownbutton)
        {
            // 점수 올라감

            // 닿으면 사라짐
            Destroy(gameObject); 
        }

        // 떨어짐
        if (this.gameObject.transform.position.y<-5.7)
        {
            GameObject UI = GameObject.Find("Hp");
            UI.GetComponent<UI>().DecreaseHp();

            Destroy(gameObject); // 닿으면 사라짐
        }

    }

}
