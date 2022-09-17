using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMover : MonoBehaviour
{
    public int health;
    public int oxygen;
    public float swimSpeed = 10f;
    public Rigidbody2D rb;
    public GameObject player;
    public GameObject idleSprite;
    public GameObject swimSprite;
    public GameObject particles;
    public float particleOffset = 10f;

    private int facingDirection = 1;
    private bool isMoving = false;

    private Vector3 forwardDirection = new Vector3(0, 0, 0);
    private Vector3 oppositeDirection = new Vector3(0, 180f, 0);

    void Start()
    {
        health = 100;
        oxygen = 100;

        rb = gameObject.GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        var xMov = Input.GetAxis("Horizontal");
        var yMov = Input.GetAxis("Vertical");
        
        transform.position += new Vector3(xMov, yMov, 0) * Time.deltaTime * swimSpeed;

        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){
            if(facingDirection != 0){
                player.transform.eulerAngles = oppositeDirection;
            }
            facingDirection = 0;
            isMoving = true;
        }

        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
            if(facingDirection != 1){
                player.transform.eulerAngles = forwardDirection;
            }    
            facingDirection = 1;
            isMoving = true;
        }

        if(isMoving){
            idleSprite.SetActive(false);
            swimSprite.SetActive(true);
        } else {
            idleSprite.SetActive(true);
            swimSprite.SetActive(false);
        }
        isMoving = false;
    }
}
