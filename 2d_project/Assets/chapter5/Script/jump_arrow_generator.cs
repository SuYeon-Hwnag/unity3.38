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
        if(delta>span) // delta가 1초보다 큰 경우
        {
            GameObject genObj = Instantiate(arrowPrefab); // 프리팹을 오브젝트로 저장
            delta = 0; // 1초마다 arrow 생성
            int px = Random.Range(-6, 7);
            genObj.transform.position = new Vector3(px, 7, 0);
        }
    }
}
