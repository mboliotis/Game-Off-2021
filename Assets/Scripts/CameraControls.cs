using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour
{

    [SerializeField] GameObject player;
    [SerializeField] Camera mainCamera;
    float offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = Mathf.Abs(player.transform.position.y - mainCamera.transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        mainCamera.transform.position = new Vector3(player.transform.position.x - 0.10f, player.transform.position.y + offset, -1f);

    }
}
