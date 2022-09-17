using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    public GameObject player;
    public GameObject cam;
    public float camOffset = 10f;

    private Vector3 playerPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        playerPos = player.transform.position;
        cam.transform.position = new Vector3(playerPos.x, playerPos.y, playerPos.z - camOffset);
    }
}
