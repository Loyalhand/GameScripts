using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInteract : MonoBehaviour
{
    private GameObject player;
    private PlayerMovement Move;
    private BoxCollider2D Interact;
    private playerDetect detect;
    private string interactable;
   
    private float colliderWidth =.75f;

    // Start is called before the first frame update
    void Start()
    {
        // reference relevant scripts
        player = GameObject.Find("Player");
        Move = player.GetComponent<PlayerMovement>();
        detect = GetComponent<playerDetect>();
        Interact = GetComponent<BoxCollider2D>();

        // resize interactor
        Interact.size = (new Vector2(colliderWidth, colliderWidth));

        // move interactor to player
        transform.position = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // move collider with pointing vector
        moveInteractor();

        // detect what is in collider
        interactable = detect.interactable;
        //Debug.Log(interactable);

       // interact
       interaction(interactable);
    }

    private void moveInteractor()
    {
        float angle;
        Vector2 movement;

        // get the movement vector
        movement = Move.playerMovement();

        if (movement != Vector2.zero)
        {
            angle = Move.getAxis(movement);

            // east
            if (angle == 0)
            {
                // Debug.Log("Interactor is east");
                transform.position = player.transform.position + new Vector3(colliderWidth, 0f, 0f);
            }
            // north
            if (angle == Mathf.PI / 2)
            {
                // Debug.Log("Interactor is north");
                transform.position = player.transform.position + new Vector3(0f, colliderWidth, 0f);
            }
            // west
            if (angle == Mathf.PI)
            {
                // Debug.Log("Interactor is west");
                transform.position = player.transform.position + new Vector3(-colliderWidth, 0f, 0f);
            }
            // south
            if (angle == -Mathf.PI / 2)
            {
                // Debug.Log("Interactor is south");
                transform.position = player.transform.position + new Vector3(0f, -colliderWidth, 0f);
            }
        }
        

        
    }

    // handles interaction depending on what is in interation box
    // pass what has interacted 
    private void interaction(string tag)
    {
        // use a switch
        //destroy collectible and add them to inventory
        
    }

}
