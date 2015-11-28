using UnityEngine;
using System.Collections;

public class jumpScript : MonoBehaviour {

    public float jumpHeight; // can be publicly set
    public bool isJumping = false; //because it doesn't start off jumping
    private Rigidbody2D rigidbody; //rigidbody gives the object physical properties
	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody2D>(); // initializing the rigidbody, so it works
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKeyDown(KeyCode.Space))
        {
            if (isJumping == false)
            {
                rigidbody.AddForce(Vector2.up * jumpHeight); //jumping
                isJumping = true;
            }
        }
	}

    //when an object collides with another object, this will happen
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Ground")
        {
            isJumping = false;
        }
    }
}
