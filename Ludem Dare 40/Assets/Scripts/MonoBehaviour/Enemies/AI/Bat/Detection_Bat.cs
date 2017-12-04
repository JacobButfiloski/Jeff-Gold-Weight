using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Detection_Bat : MonoBehaviour {

    public Animator anim;
    public GameObject startPoint;
    public float moveSpeed;
    public GameObject bat;
    public Rigidbody2D rigidBody;
    public GameObject Player;
    private bool playerOutOfRange;
    float _x;
    float _y;
    float _z;
    public float startpointX;

    // Use this for initialization
    private void Update()
    {
        this.transform.position = bat.transform.position;
        _x = bat.transform.position.x;
        _y = bat.transform.position.y;
        _z = bat.transform.position.z;

        if (playerOutOfRange)
        { 
            if (Math.Round(bat.transform.position.x) == startpointX)
            {
                bat.transform.position = startPoint.transform.position;
                anim.SetBool("isFlying", false);
                playerOutOfRange = false;
            } else
            {
                bat.transform.position = Vector3.Lerp(bat.transform.position, startPoint.transform.position, moveSpeed* Time.deltaTime);
            }
            
        }


    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            anim.SetBool("isFlying", true);
            bat.transform.position = Vector3.Lerp(bat.transform.position, other.transform.position, moveSpeed * Time.deltaTime);

            if (Player.transform.position.x < bat.transform.position.x)
            {
                bat.transform.localScale = new Vector3(1, 1, 1);
            }
            else if (Player.transform.position.x > bat.transform.position.x)
            {
                bat.transform.localScale = new Vector3(-1, 1, 1);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.name == "Player")
        {
            if(bat.transform.position == startPoint.transform.position)
            {
                anim.SetBool("isFlying", false);
            } else
            {
                //bat.transform.position = startPoint.transform.position;
                //anim.SetBool("isFlying", false);
                playerOutOfRange = true;
            }
        }
        
    }
}
