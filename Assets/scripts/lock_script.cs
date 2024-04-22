using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lock_script : MonoBehaviour
{
    key_script KS;
    // Start is called before the first frame update
    void Start()
    {
        KS = GetComponentInChildren<key_script>();
    }

    // Update is called once per frame
    void Update()
    {
        if(KS.locked==false)
        {
            Destroy(gameObject);
        }
    }
}
