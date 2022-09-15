using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -0.1f, 0); // 떨어짐

        if(transform.position.y < -5.0f) // 화면 밖으로 나가면 삭제
        {
            Destroy(gameObject);
        }

        // 충돌 판정
        Vector2 p1 = transform.position; // 화살 중심 좌표
        Vector2 p2 = this.player.transform.position; // 플레이어 중심 좌표
        Vector2 dir = p1 - p2;
        float d = dir.magnitude; // 벡터 길이 
        float r1 = 0.5f; // 화살 반경
        float r2 = 0.5f; // 플레이어 반경

        if(d<r1+r2)
        {
            GameObject UIcontroller = GameObject.Find("Hp");
            UIcontroller.GetComponent<UI>().DecreaseHp();

            Destroy(gameObject); // 닿으면 사라짐
        }

    }
}
