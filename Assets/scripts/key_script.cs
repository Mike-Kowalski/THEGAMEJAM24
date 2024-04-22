using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key_script : collectable_script
{
    [SerializeField]
    public bool locked;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    public override void OnCollisionEnter2D(Collision2D collision)
    {
        locked = false;
        base.OnCollisionEnter2D(collision);
    }
}
