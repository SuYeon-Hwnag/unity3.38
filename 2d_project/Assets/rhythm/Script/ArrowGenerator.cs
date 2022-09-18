using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public List<GameObject> arrowList;
    public List<float> genTiming; // 생성 시간
    public List<float> genDir; // 생성 방향

    int genCount = 0;
    float deltaTime = 0.0f;
    public bool isStart = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
 
            if (genTiming.Count <= genCount)
            {
                return;
            }

            deltaTime += Time.deltaTime;

            if (deltaTime > genTiming[genCount])
            {
                deltaTime = 0;
                genCount = Random.Range(0, 3);
                GenArrow(genDir[genCount]);
                genCount++;
                //GameObject gameObject = Instantiate(arrow_prefab) as GameObject;
                // int px = Random.Range(-2, 2);
                //gameObject.transform.position = new Vector3(px, 5, 0); // 정해진 위치에서 랜덤 생성
            }


    }

    public void GenArrow(float number)
    {
        Instantiate(arrowList[(int)number]);
    }

}
