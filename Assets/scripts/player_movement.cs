using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    public int jumpPower;
    [SerializeField]
    private int jumpDir;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(left))
        {
            transform.position -=new Vector3 (5, 0, 0)*Time.deltaTime;
        }
        
        if (Input.GetKey(right))
        {
            transform.position += new Vector3(5, 0, 0)*Time.deltaTime;
        }

        if(Input.GetKeyDown(jump))
        {
            rb.AddForce(transform.up*jumpDir * jumpPower);
        }
    }
}
