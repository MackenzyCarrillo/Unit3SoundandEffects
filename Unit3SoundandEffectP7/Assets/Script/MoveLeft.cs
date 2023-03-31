using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30;
    private PlayerController playerControllerScript;
    private float leftBound = -15;

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
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        // makes it so it destroys any object with the obsticle game tag
        if (transform.position.x < leftBound && gameObject.CompareTag("Obsticle"))
        {
            Destroy(gameObject);
        }

       
        
        if (playerControllerScript.gameOver == false)
        {
            if(playerControllerScript.doubleSpeed)
            {
                transform.Translate(Vector3.left * Time.deltaTime * (speed * 2));
            }
             
            else
            {
                transform.Translate(Vector3.left * Time.deltaTime * speed);
            }
        }

    
    }
}
