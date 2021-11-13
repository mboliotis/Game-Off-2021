using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] Rigidbody2D playersRigit;
    [SerializeField] GameObject gun;

    float speed = 10f, upForce = 300f;
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
            playersRigit.gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
        }
        else
        {
            playerRight = false;
        }

        
   
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerLeft = true;
            playersRigit.gameObject.transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else
        {
            playerLeft = false;
        }

        if (Input.GetKey(KeyCode.W))
        {
            gun.GetComponent<GunMechanics>().fire = true;
        }
        else
        {
            gun.GetComponent<GunMechanics>().fire = false;
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
            if(playersRigit.velocity.x < 5f)
            {
                playersRigit.AddForce(transform.right * speed);
            }
            
        }
        
        if (playerLeft)
        {
            if (playersRigit.velocity.x > -5f)
            {
                playersRigit.AddForce(transform.right * -speed);
            }
                
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
