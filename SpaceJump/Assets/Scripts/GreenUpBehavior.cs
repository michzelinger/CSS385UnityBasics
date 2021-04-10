using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenUpBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    public bool grounded = true;
    private Rigidbody2D rb2d;
    public float jumpPower;
    private BoxCollider2D boxCollider2D;
    [SerializeField] private LayerMask platformsLayerMask;
    public float speed = 10f;

    void Start()
    {
        rb2d = rb2d = GetComponent<Rigidbody2D> ();
        boxCollider2D = transform.GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        Vector3 pos = transform.position;
        if(Input.GetKeyDown(KeyCode.Space) && IsGrounded()) {
            rb2d.velocity = Vector2.up * jumpPower;
        }
        if(Input.GetKey(KeyCode.D))
        {
            pos.x += speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.A))
        {
            pos.x -= speed * Time.deltaTime;
        }
        transform.position = pos;
    }

    private bool IsGrounded() {
        RaycastHit2D raycastHit2D = Physics2D.BoxCast(boxCollider2D.bounds.center, boxCollider2D.bounds.size, 0f, Vector2.down, 0.1f, platformsLayerMask);
        return raycastHit2D.collider != null;
    }
}
