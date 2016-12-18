using UnityEngine;
using System.Collections;

public class PlayerAnimation : MonoBehaviour {

    private Animator anim;

    private PlayerMovement move;

    public float speedPlayer;

    private string playername;

    // Use this for initialization
    void Start () {
        playername = gameObject.name;
        move = GameObject.Find(playername).GetComponent<PlayerMovement>();

        anim = GameObject.Find(playername).GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        speedPlayer = GameObject.Find(playername).GetComponent<PlayerMovement>().tomovex;

        AnimPlayer();
    }

    void AnimPlayer() {
        if (speedPlayer > 0.1f)
        {
            anim.Play("Turn Right");
        }
        else
        {
            if (speedPlayer < -0.1f)
            {
                anim.Play("Turn Left");
            }
        }

    }
}
