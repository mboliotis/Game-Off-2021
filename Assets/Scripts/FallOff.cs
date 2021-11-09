using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallOff : MonoBehaviour
{
    [SerializeField] GameObject respawn;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.position = respawn.transform.position;
        }
    }
}
