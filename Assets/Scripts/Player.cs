using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    Vector2 move = new Vector2();
    // Boolean for Jumping
    bool ifJump = false;
    
    // Use this for initialization
    void Start () {
        // Set player position
        transform.position = new Vector2(-7.89f, -2.52f);
        

	}
	
	// Update is called once per frame
	void Update () {

       

        // Check the player's input
        if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)))
        {
            ifJump = true;
            if (ifJump == true)
            {
                // Move backwards
                move.y += 0.3f;
            }
            ifJump = false;
        }

        // Get character controller
        GetComponent<CharacterController>().Move(move);


    }
}
