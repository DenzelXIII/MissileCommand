using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private int dir;
    [SerializeField]
    private float speed;
    private Transform myTransform;
    private bool facingRight;

	// Use this for initialization
	void Start ()
    {
	}
	
	// Update is called once per frame
	void Update ()
    {
        MovementInDirection();
        if (this.transform.position.x >= 20)
        {
            transform.position = new Vector3(-17,transform.position.y,transform.position.z);
        }
	}

    void MovementInDirection()
    {
        Vector2 movement = new Vector2(speed, 0) * dir * Time.deltaTime;
        transform.Translate(movement);
        if (dir == -1)
        {
            if (facingRight)
            {
                Flip();
            }
        }
        else if (dir == 1)
        {
            if (!facingRight)
            {
                Flip();
            }
        }
    }

    void Flip()
    {
        facingRight = !facingRight;

        Vector2 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
