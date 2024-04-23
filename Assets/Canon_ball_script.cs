using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon_ball_script : MonoBehaviour
{
    [SerializeField]
    public bool left;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (left)
        {
            transform.position -= new Vector3(5, 0, 0) * Time.deltaTime;
        }
        else
        {
            transform.position += new Vector3(5, 0, 0) * Time.deltaTime;
        }
    }
}
