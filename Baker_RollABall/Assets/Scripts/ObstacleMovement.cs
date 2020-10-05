using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    bool goingLeft = true;
    private Vector3 startPosition;
    public float speed = .1f;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (goingLeft)
        {
            if (transform.position.x > startPosition.x - 3)
            {
                transform.position.x = transform.position.x - speed;
            }
                    }
    }
}
