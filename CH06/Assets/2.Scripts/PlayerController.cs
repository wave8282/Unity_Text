using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    public float jumpForce = 400f;
    public float walkForce = 30f;
    public float MaxWalkSpeed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        rigid2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && rigid2D.velocity.y == 0)
        {
            //rigid2D.AddForce(transform.up * jumpForce);
            rigid2D.AddForce(new Vector2(0,1) * jumpForce);
        }
        int key = 0;
        if(Input.GetKey(KeyCode.RightArrow)) key = 1;
        if(Input.GetKey(KeyCode.LeftArrow)) key = -1;


        float speedX = Mathf.Abs(rigid2D.velocity.x);

        if(speedX < MaxWalkSpeed)
        {
            rigid2D.AddForce(transform.right * key * walkForce);
        }
        //rigid2D.AddForce(transform.right * key * walkForce);
        if(key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }
        animator.speed = speedX / 2.0f;

        if(transform.position.y < -10);
        {
            SceneManager.LoadScene("GameScene1");
        }
    }
    private void OnTrigger
}
