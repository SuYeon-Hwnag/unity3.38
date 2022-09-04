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
        // �����Ӹ��� ������� ���Ͻ�Ų��.
        gameObject.transform.Translate(0, arrowspped, 0);
        arrowspped *= 1.004f;

        // ȭ�� ������ ������ �Ҹ��Ѵ�. 
        if(gameObject.transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        // �浹����
        Vector2 p1 = gameObject.transform.position; // ȭ��ǥ
        Vector2 p2 = player.transform.position; // �÷��̾�

        Vector2 dir = p1 - p2;

        float d = dir.magnitude; // ���� ���� ��ȯ

        float r1 = 0.5f; // ȭ��ǥ�� �ݰ�
        float r2 = 1.0f; // �÷��̾��� �ݰ�

        if (d <= r1 + r2) // ���� ���
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
