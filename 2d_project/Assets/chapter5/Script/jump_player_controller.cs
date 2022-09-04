using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump_player_controller : MonoBehaviour
{
    public bool stiffness = false;
    float delta;
    float delta2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // GetKeyDown �� �� 
        // GetKey �����Ӹ��� ���
        // GetKeyUp
        // ���� ȭ��ǥ -> ���� �̵�

        

        if (stiffness == true)
        {
            Color catcolor = gameObject.GetComponent<SpriteRenderer>().color;
            delta += Time.deltaTime;
            delta2 += Time.deltaTime;

            if (delta>0.3f)
            {
                delta = 0;
                // ���� ����
                if(catcolor.a==0)
                {
                    catcolor.a = 1;
                    gameObject.GetComponent<SpriteRenderer>().color = catcolor;
                }

                // ���� ����
                else if(catcolor.a ==1)
                {
                    catcolor.a = 0;
                    gameObject.GetComponent<SpriteRenderer>().color = catcolor;
                }
            }

            else if(delta2 > 1.3f)
            {
                delta2 = 0;
                stiffness = false;
                catcolor.a = 1;
                gameObject.GetComponent<SpriteRenderer>().color = catcolor;
            }


        }

        else if(stiffness == false)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                gameObject.transform.Translate(-0.03f, 0, 0);
            }

            // ������ ȭ��ǥ -> ������ �̵�

            if (Input.GetKey(KeyCode.RightArrow))
            {
                gameObject.transform.Translate(0.03f, 0, 0);
            }
        }
    }
    public void Hit(bool a)
    {
        stiffness = a;
    }
}
