using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_movement : MonoBehaviour
{
    [SerializeField]
    KeyCode left;
    [SerializeField]
    KeyCode right;
    [SerializeField]
    KeyCode jump;
    Rigidbody2D rb;
    [SerializeField]
    public float jumpPower;
    [SerializeField]
    private int jumpDir;
    public bool canJump;
    public float jumpTime=1;
    public float jumpTimeCounter=1;
    public LayerMask platform;
    public bool stopJump;
    public Transform groundCheck;
    public float groundCheckRadius;
    public int collectablesTotal;
    public int collectablesCollected;
    [SerializeField]
    public int curent_lvl;
    public string[] levels;
    // Start is called before the first frame update
    void Start()
    {
        jumpTimeCounter = jumpTime;
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        canJump = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, platform);
        
        if(canJump)
        {
            jumpTimeCounter = jumpTime;
        }

        if (Input.GetKey(left))
        {
            transform.position -=new Vector3 (5, 0, 0)*Time.deltaTime;
        }
        
        if (Input.GetKey(right))
        {
            transform.position += new Vector3(5, 0, 0)*Time.deltaTime;
        }

        if (Input.GetKeyDown(jump))
        {
            if (canJump)
            {
                rb.AddForce(transform.up * jumpDir * jumpPower);
                stopJump = false;
                
            }
        }
         if(Input.GetKey(jump)&&!stopJump)
        {
            if(jumpTimeCounter>0)
            {
                rb.AddForce(transform.up * jumpDir * jumpPower);
                jumpTimeCounter -= Time.deltaTime;
            }
        }
         if(Input.GetKeyUp(jump))
        {
            jumpTimeCounter = 0;
            stopJump = true;
          
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="hazard")
        {
       //    gameOver();
        }
        if(collision.gameObject.tag=="collectable")
        {
            collect();
        }
        if(collision.gameObject.tag=="goal")
        {
            next_level();
        }
    }
    public void gameOver()
    {
        SceneManager.LoadScene("GameOver", LoadSceneMode.Single);      
    }
    public void collect()
    {
        collectablesCollected += 1;
        if (collectablesCollected == collectablesTotal)
        {
            unlock();
        }
    }
    public void unlock()
    {
        print("yay unlocked");
    }
    public void next_level()
    {
        SceneManager.LoadScene(levels[curent_lvl+1],LoadSceneMode.Single);       
        
    }
}
