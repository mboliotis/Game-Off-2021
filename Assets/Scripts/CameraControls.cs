using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour
{

    [SerializeField] GameObject player;
    [SerializeField] Camera mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mainCamera.transform.position = new Vector3(player.transform.position.x - 0.10f, 0, -1f);
    }
}
