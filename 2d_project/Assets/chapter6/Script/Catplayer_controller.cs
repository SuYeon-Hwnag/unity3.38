using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Catplayer_controller : MonoBehaviour
{
    Rigidbody2D rigid2D;
    float jumpForce = 680.0f;
    float walkForce = 30.0f;
    float maxwalkSpeed = 3.0f;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rigid2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //jump
        if(Input.GetKeyDown(KeyCode.Space) && rigid2D.velocity.y == 0)
        {
            rigid2D.AddForce(transform.up * jumpForce);
        }

        // 좌우 이동
        int key = 0;
        if(Input.GetKey(KeyCode.RightArrow))
        {
            key = 1;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            key = -1;
        }

        // 플레이어 속도 체크
        float speedx = Mathf.Abs(rigid2D.velocity.x);

        // 스피드 제한
        if(speedx<maxwalkSpeed)
        {
            rigid2D.AddForce(transform.right * key * this.walkForce);
        }

        // 움직이는 방향 전환
        if(key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }

        // 플레이어 속도에 맞춰 애니메이션 속도 변경
        animator.speed = speedx / 2.0f;

        // 플레이어가 화면 밖으로 나갔다면 처음부터
        if(transform.position.y<-10)
        {
            SceneManager.LoadScene("Jumping");
        }
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("ClearScene");
    }
}
