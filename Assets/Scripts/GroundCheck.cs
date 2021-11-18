using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    [SerializeField] GameObject player;



    private void Update()
    {
        if(this.gameObject.transform.parent == null)
        {
            this.gameObject.transform.SetParent(player.transform);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 7)
        {
            player.GetComponent<PlayerMovement>().playerJump = true;
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 7)
        {
            player.GetComponent<PlayerMovement>().playerJump = false;
        }
    }
}
