using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] Rigidbody2D playersRigit;
    [SerializeField] GameObject player;
    float speed = 20f, upForce = 300f;
    bool playerLeft, playerRight, canJump;
    public bool playerJump;
    // Start is called before the first frame update
    void Start()
    {
        playerLeft = false;
        playerRight = false; 
        playerJump = false;
        canJump = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            playerRight = true;
        }
        else
        {
            playerRight = false;
        }

        
   
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerLeft = true;
        }
        else
        {
            playerLeft = false;
        }

        if (playerJump)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                canJump = true;
            }
        }

         

    }

    private void FixedUpdate()
    {
        if (playerRight)
        {
            playersRigit.AddForce(transform.right * speed);
        }
        
        if (playerLeft)
        {
            playersRigit.AddForce(transform.right * -speed);
        }
        
        if (!playerRight && !playerLeft)
        {
            playersRigit.velocity *= new Vector2(0f, 1f);
        }

        if (canJump)
        {
            playersRigit.AddForce(transform.up * upForce);
            canJump = false;
        }
    }



}
