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
        // transform.Translate(0, -0.1f, 0); // ������

        transform.Translate(Vector3.down * 0.1f); //-> ȭ��ǥ ��� ���� �Ʒ�����

        if (this.transform.position.y > -5.0f && this.transform.position.y < -3.75f && GameObject.Find("GameDirector").GetComponent<button_controller>().islbutton)
        {
            // ���� �ö�

            // ������ �����
            Destroy(gameObject);
        }

        // ������
        if (this.gameObject.transform.position.y < -5.7)
        {
            GameObject UI = GameObject.Find("Hp");
            UI.GetComponent<UI>().DecreaseHp();

            Destroy(gameObject); // ������ �����
        }

    }

}