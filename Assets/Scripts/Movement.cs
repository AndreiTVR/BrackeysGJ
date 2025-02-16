using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    /**
     movement script extrem de barebones, esti si tu in stare sa intelegi
     */
    [SerializeField] float movementSpeed = 5f;
    [SerializeField] float direction;
    [SerializeField] Rigidbody2D rb;
    bool isFacingRight = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        direction = Input.GetAxisRaw("Horizontal");
        Flip();
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(movementSpeed * direction, rb.velocity.y);
    }
    private void Flip()
    {
        if(isFacingRight && direction<0f || isFacingRight && direction >0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localscale = transform.localScale;
            localscale.x *= -1f;
            transform.localScale = localscale;
        }    
    }
}
