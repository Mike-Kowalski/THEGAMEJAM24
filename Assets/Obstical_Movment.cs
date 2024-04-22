using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstical_Movment : MonoBehaviour
{
    public GameObject[] points;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2.MoveTowards(transform.position, points[1].transform.position, Time.deltaTime * speed);
    }
}
