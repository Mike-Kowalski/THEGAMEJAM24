using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectable_script : MonoBehaviour
{
    [SerializeField]
    public int level;
    [SerializeField]
    public bool colleted;
    [SerializeField]
   public string fileName;
    Save_Class enteries = new(0, 0, 0, 0, false, false, false, false, false, false);
    // Start is called before the first frame update
    void Start()
    {
        enteries = file_handler.readFromJson<Save_Class>(fileName);
        if(level==1)
        {
            colleted = enteries.Collected1;
        }
        if (level == 2)
        {
            colleted = enteries.Collected2;
        }
        if (level == 3)
        {
            colleted = enteries.Collected3;
        }
        if (level == 4)
        {
            colleted = enteries.Collected4;
        }
        if (level == 5)
        {
            colleted = enteries.Collected5;
        }
        if (level == 6)
        {
            colleted = enteries.Collected6;
        }
        if(colleted==true)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public virtual void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            colleted = true;
            if (level == 1)
            {
                enteries.Collected1=colleted;
            }
            if (level == 2)
            {
                enteries.Collected1 = colleted;
            }
            if (level == 3)
            {
                enteries.Collected1 = colleted;
            }
            if (level == 4)
            {
                enteries.Collected1 = colleted;
            }
            if (level == 5)
            {
                enteries.Collected1 = colleted;
            }
            if (level == 6)
            {
                enteries.Collected1 = colleted;
            }
            Destroy(gameObject);
        }
    }
}
