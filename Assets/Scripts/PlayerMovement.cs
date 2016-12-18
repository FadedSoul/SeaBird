using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    private float moveX;

    public float tomovex
    {
        get
        {
            return moveX;
        }
    }

    [SerializeField]
    private float speed = 5f;

    [SerializeField]
    private float jumpSpeed = 300f;

    private bool jumping = false;
    private float keepSpeed;
    private Rigidbody2D rigid;

    private string playerName;

    // Use this for initialization
    void Start () {
        playerName = gameObject.name;

        rigid = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {

        Move();
        Jump();
        
    }

    void Move() {
        moveX = Input.GetAxisRaw(playerName);

        if (Input.anyKeyDown)
        {
            keepSpeed = moveX;
        }

        Vector2 move = new Vector2(moveX * speed, rigid.velocity.y);
        rigid.velocity = move;
    }

    void Jump() {
        if (Input.GetKeyDown("w") && !jumping)
        {
            rigid.AddForce(Vector2.up * jumpSpeed);
            jumping = true;
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Ground")
        {
            jumping = false;
        }
    }
}
