using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int EnemySpeed;
    public int XMoveDirection;

    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, new Vector2 (XMoveDirection, 0));
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(XMoveDirection, 0) * EnemySpeed;
        if (hit.distance < 0.7f)
        {
            Flip();
        }
    }

    void Flip()
    {
        if (XMoveDirection > 0)
        {
            XMoveDirection = -1;
            float x = -0.2654173f * 2;
            float y = 0.0f;
            float z = 0.0f;
            transform.localScale += new Vector3(x, y, z);
        }
        else
        {
            XMoveDirection = 1;
            float x = 0.2654173f * 2;
            float y = 0.0f;
            float z = 0.0f;
            transform.localScale += new Vector3(x, y, z);
        }
    }
}
