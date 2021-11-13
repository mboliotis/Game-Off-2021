using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorMove : MonoBehaviour
{
    [SerializeField] GameObject dest;
    Vector3 startPos, endPos;
    bool move;
    // Start is called before the first frame update
    void Start()
    {
        move = false;
        startPos = this.gameObject.transform.position;
        endPos = dest.transform.position;
    }

    private void Update()
    {
        if ( Mathf.Abs(this.gameObject.transform.position.y - endPos.y) < 0.1f)
        {
            this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
             
        }

        if (move)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 2f);
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.SetParent(this.gameObject.transform);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        collision.gameObject.transform.SetParent(null);
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            move = true;
        }

    }
}
