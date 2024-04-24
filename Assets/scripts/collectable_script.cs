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
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public virtual void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {

            Destroy(gameObject);
        }
    }
}
