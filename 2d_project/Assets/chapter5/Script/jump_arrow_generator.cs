using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump_arrow_generator : MonoBehaviour
{
    public GameObject arrowPrefab;
    float span = 1.0f;
    float delta = 0;

    // Update is called once per frame
    void Update()
    {

        delta += Time.deltaTime;
        if(delta>span) // delta�� 1�ʺ��� ū ���
        {
            GameObject genObj = Instantiate(arrowPrefab); // �������� ������Ʈ�� ����
            delta = 0; // 1�ʸ��� arrow ����
            int px = Random.Range(-6, 7);
            genObj.transform.position = new Vector3(px, 7, 0);
        }
    }
}
