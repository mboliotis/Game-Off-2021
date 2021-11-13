using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderMove : MonoBehaviour
{
    [SerializeField] Rigidbody2D spiderRig;
    Vector2 left, right;
    int direction;
    float x_scale;
    // Start is called before the first frame update
    void Start()
    {
        direction = -1;
        left = spiderRig.position - new Vector2(10f, 0f );
        right = spiderRig.position + new Vector2(10f, 0f );
        x_scale = spiderRig.gameObject.transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Mathf.Abs(left.x - spiderRig.position.x) < 0.1f)
        {
            direction = 1;
            spiderRig.gameObject.transform.localScale = new Vector3(-x_scale, spiderRig.gameObject.transform.localScale.y, spiderRig.gameObject.transform.localScale.z);
        }
        else if (Mathf.Abs(right.x - spiderRig.position.x) < 0.1f)
        {
            spiderRig.gameObject.transform.localScale = new Vector3(x_scale, spiderRig.gameObject.transform.localScale.y, spiderRig.gameObject.transform.localScale.z);
            direction = -1;
        }
        else
        {
            // Do Nothing
        }

    }

    private void FixedUpdate()
    {
        
        if (direction > 0)
        {
            spiderRig.velocity = new Vector2(5f, 0f)*direction;
        }
        else
        {
            spiderRig.velocity = new Vector2(5f, 0f)*direction;
        }
        
    }
}
