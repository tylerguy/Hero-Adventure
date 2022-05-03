using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    Rigidbody2D Rb2d;
    public float MoveVelocity;
    public float JumpVelocity;
    public LayerMask Layer;
    public float Length;

    // Start is called before the first frame update
    void Start()
    {
        Rb2d = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        Walk();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump(); 
        }
    }

    void Walk()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float MoveVector = x * MoveVelocity;

        Rb2d.AddForce(new Vector2(MoveVector, 0), ForceMode2D.Force);
    }

    
    bool OnFloor()
    {
        RaycastHit2D RayHit = Physics2D.Raycast(transform.position, Vector2.down, Length, Layer);
        Debug.DrawRay(transform.position,Vector3.down, Color.green, 10f);
        
        if (RayHit.collider != null)
        {
            if (RayHit.distance <= 0.6f)
            {
                Debug.Log(RayHit.distance);
                return true;
            }
            return false;
        }
        return false;
    }

    void Jump()
    {
        if (OnFloor())
        {
            Rb2d.AddForce(new Vector2(0, JumpVelocity), ForceMode2D.Impulse);
        }
    }
}
