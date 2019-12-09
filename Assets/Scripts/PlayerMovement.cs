using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public int playerSpeed = 10;
    public bool facingRight = false;
    public int playerJumpPower = 300;
    public float moveX;
    public bool isGrounded;

	void Start () {
		
	}
	
	void Update ()
    {
        Move();
	}

    public void Move()
    {
        //CONTROLS
        moveX = Input.GetAxis("Horizontal");
        if(Input.GetButtonDown ("Jump") && isGrounded == true)
        {
            Jump();
        }

        //ANIMATIONS
        //PLAYER DIRECTION
        if(moveX < 0.0f && facingRight == false)
        {
            FlipPlayer();
        }
        else if (moveX > 0.0f && facingRight == true)
        {
            FlipPlayer();
        }
        //PHYSICS
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);

    }

    public void Jump()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * playerJumpPower);
        isGrounded = false;

    }

   public void FlipPlayer()
    {
        facingRight = !facingRight;
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Player has collided with " + col.collider.name);
        if(col.gameObject.tag == "ground")
        {
            isGrounded = true;
        }
    }
}
