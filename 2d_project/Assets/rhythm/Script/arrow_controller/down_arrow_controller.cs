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
        // transform.Translate(0, -0.1f, 0); // ������

        transform.Translate(Vector3.down * 0.1f); //-> ȭ��ǥ ��� ���� �Ʒ�����

        // �浹 ����
        /*
        Vector2 p1 = transform.position; // ȭ�� �߽� ��ǥ
        Vector2 p2 = this.Downbutton.transform.position; // ��ư �߽� ��ǥ
        Vector2 dir = p1 - p2;
        float d = dir.magnitude; // ���� ���� 
        float r1 = 0.5f; // ȭ�� �ݰ�
        float r2 = 0.5f; // ��ư �ݰ�
        Debug.Log(d);
        Debug.Log("jjj");
        */

        if (this.transform.position.y > -5.0f && this.transform.position.y < -3.75f && GameObject.Find("GameDirector").GetComponent<button_controller>().isdownbutton)
        {
            // ���� �ö�

            // ������ �����
            Destroy(gameObject); 
        }

        // ������
        if (this.gameObject.transform.position.y<-5.7)
        {
            GameObject UI = GameObject.Find("Hp");
            UI.GetComponent<UI>().DecreaseHp();

            Destroy(gameObject); // ������ �����
        }

    }

}
