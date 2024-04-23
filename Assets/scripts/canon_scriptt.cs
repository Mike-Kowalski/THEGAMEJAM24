using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canon_scriptt : MonoBehaviour
{
    [SerializeField]
    GameObject canonBall;
    [SerializeField]
   public float FireRate;
    public float cooldown;
    // Start is called before the first frame update
    void Start()
    {
        cooldown = 0;
    }

    // Update is called once per frame
    void Update()
    {
        cooldown += 1 * Time.deltaTime;
        if(cooldown>=FireRate)
        {
            Fire();
            cooldown = 0;
        }
        
        
    }
    public void Fire()
    {
        Instantiate(canonBall, transform.position, Quaternion.identity);
    }
}
