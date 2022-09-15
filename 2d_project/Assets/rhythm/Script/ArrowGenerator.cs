using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrow_prefab;
    float span = 1.0f;
    float delta = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta>this.span)
        {
            this.delta = 0;
            GameObject gameObject = Instantiate(arrow_prefab) as GameObject;
            int px = Random.Range(-2, 2);
            gameObject.transform.position = new Vector3(px, 5, 0); // 정해진 위치에서 랜덤 생성
        }
    }
}
