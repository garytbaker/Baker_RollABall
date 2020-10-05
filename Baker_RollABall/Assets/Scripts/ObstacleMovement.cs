using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleMovement : MonoBehaviour
{
    private Vector3 startPosition;  //the start position of the obstacle
    private Vector3 endPosition;   //where the obstacle will end at
    public float speed = .1f;      //how fast the obstacle will move
    public Vector3 change = new Vector3(10f,0f,0f);   //the difference in position
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;   //setting the positions
        endPosition = startPosition + change;
    }

    // Update is called once per frame
    void Update()
    {
        float movement = Mathf.PingPong(Time.time * speed, 1f);  //making it go back and forth

        transform.position = Vector3.Lerp(startPosition, endPosition, movement);   //the actual movement of the object
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))   //checks to see if the player is hit
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);   //restarts the game if the player was hit
        }
    }
}
