using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    bool goingLeft = true;
    private Vector3 startPosition;
    public Vector3 endPosition;
    public float speed = .1f;
    public Vector3 change = new Vector3(10f,0f,0f);
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        endPosition = startPosition + change;
    }

    // Update is called once per frame
    void Update()
    {
        float movement = Mathf.PingPong(Time.time * speed, 1f);

        transform.position = Vector3.Lerp(startPosition, endPosition, movement);
    }
}
