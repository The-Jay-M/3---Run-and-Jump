using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 30.0f;
    private PlayerController playerControllerScript;
    private float leftboundary = -15;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        // Remember this script is used to move objects, here - bg and obstacle
        // so now after making said objects move if gameOver bool still returns false,
        // we destroy obstacles that are some point off the screen and make sure this does not
        // affect the bg by using the in-built CompareTag method 
        if (transform.position.x < leftboundary && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
