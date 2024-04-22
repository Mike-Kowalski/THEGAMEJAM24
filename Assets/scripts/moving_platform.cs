using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_platform : MonoBehaviour
{
    [SerializeField]
    public float speedX;
    [SerializeField]
    public float speedY;
    [SerializeField]
    public float originY;
    public float originX;
    [SerializeField]
    public float MoveDistanceX;
    [SerializeField]
    public float MoveDistanceY;
    // Start is called before the first frame update
    void Start()
    {
        originX = transform.position.x;
        originY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if(originX-transform.position.x>MoveDistanceX)
        {
            speedX = speedX * -1;
        }
        else if(originX - transform.position.x < -MoveDistanceX)
        {
            speedX = speedX * -1;
        }
        if (originY - transform.position.y > MoveDistanceY)
        {
            speedY = speedY * -1;
        }
        else if (originY - transform.position.y < -MoveDistanceY)
        {
            speedY = speedY * -1;
        }
        transform.Translate(speedX*Time.deltaTime, speedY*Time.deltaTime, 0);
    }
}
