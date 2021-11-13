using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderHealth : MonoBehaviour
{
    int HP ;
    private void Start()
    {
        HP = 5;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            HP -= 1;
        }

        if (HP == 0)
        {
            Destroy(this.gameObject);
        }
    }


}
