using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump_arrow_controller : MonoBehaviour
{
    GameObject player;
    // public bool stiffness = false;
    float arrowspped = -0.02f;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        // 프레임마다 등속으로 낙하시킨다.
        gameObject.transform.Translate(0, arrowspped, 0);
        arrowspped *= 1.004f;

        // 화면 밖으로 나가면 소멸한다. 
        if(gameObject.transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        // 충돌판정
        Vector2 p1 = gameObject.transform.position; // 화살표
        Vector2 p2 = player.transform.position; // 플레이어

        Vector2 dir = p1 - p2;

        float d = dir.magnitude; // 벡터 길이 반환

        float r1 = 0.5f; // 화살표의 반경
        float r2 = 1.0f; // 플레이어의 반경

        if (d <= r1 + r2) // 닿은 경우
        {
            GameObject director = GameObject.Find("GameManager");

            Destroy(gameObject);

            GameObject stiffness = GameObject.Find("player");

            if(player.GetComponent<jump_player_controller>().stiffness == false)
            {
                stiffness.GetComponent<jump_player_controller>().Hit(true);
                director.GetComponent<GameManager>().DecreaseHp();
            }
        }
    }


}
