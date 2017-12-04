using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public GameObject ExitButton;

    public ScoreManager theScoreManager;

    public float moveSpeed;
    public float jumpForce;
    /* 
	public KeyCode left;
	public KeyCode right;
	public KeyCode jump;
	public KeyCode attack;
	public KeyCode devConsole;
	
	//controller
	public KeyCode leftJS;
	public KeyCode rightJS;
	public KeyCode jumpJS;
	public KeyCode attackJS;
	*/
    private Rigidbody2D rigidBody;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask ground;

    //player data
    float _playerX;
    float _playerY;
    float _playerZ;
    public float _lastMoveSpeed = 50;

    //axis checks
    private bool cancel_AxisInUse = false;
    public bool jump_AxisInUse = false;
    private bool attack_AxisInUse = false;
    private bool dev_AxisInUse = false;
    private bool submit_AxisInUse = false;
    //
    public bool isGrounded;

    private Animator anim;

    public GameObject fireBall;
    public Transform throwPoint;

    public bool isAttacking;

    private bool devConsoleIsActive = false;
    public GameObject DevConsole;

    //power ups
    private bool hasPowerup;
    private bool tripleShot;
    private bool bigShot;


    //triple shot
    private Vector3 fireBallTop;
    private Vector3 fireBallBottom;

    //big shot
    public GameObject fireBall_large;
    private Vector3 fireBallBig;

    // Use this for initialization
    void Start()
    {
        devConsoleIsActive = false;
        rigidBody = GetComponent<Rigidbody2D>();

        anim = GetComponent<Animator>();

        _playerX = this.transform.localScale.x;
        _playerY = this.transform.localScale.y;
        _playerZ = this.transform.localScale.z;

    }

    // Update is called once per frame

    IEnumerator ThrowGold()
    {
        yield return new WaitForSeconds(1);
        
    }
    void Update()
    {
        

        if (!devConsoleIsActive)
        {

            /*if (this.anim.GetCurrentAnimatorStateInfo(0).IsName("Player1_ATTACK"))
            {
                isAttacking = true;
            }
            else
            {
                isAttacking = false;
            }*/

            isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, ground);
            if (!isAttacking)
            {

                if (Input.GetAxisRaw("Left") != 0)
                {
                    rigidBody.velocity = new Vector2(-moveSpeed / 10, rigidBody.velocity.y);
                    anim.SetBool("isMoving", true);
                }
                else if (Input.GetAxisRaw("Right") != 0)
                {
                    rigidBody.velocity = new Vector2(moveSpeed / 10, rigidBody.velocity.y);
                    anim.SetBool("isMoving", true);
                }
                else
                {
                    rigidBody.velocity = new Vector2(0, rigidBody.velocity.y);
                    anim.SetBool("isMoving", false);
                }

                if (Input.GetAxisRaw("Jump") != 0 && isGrounded)
                {
                    if (!jump_AxisInUse)
                    {
                        rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpForce / 10);
                        jump_AxisInUse = true;
                    }
                }
                else if (Input.GetAxisRaw("Jump") == 0)
                {
                    jump_AxisInUse = false;
                }

                float _inAirSpeed = 60;
                if (!isGrounded)
                {
                    moveSpeed = _inAirSpeed;
                } else
                {
                    moveSpeed = _lastMoveSpeed;
                }

                if (isGrounded)
                {
                    _lastMoveSpeed = moveSpeed;
                }

                if(rigidBody.velocity.y < 0)
                {
                    rigidBody.gravityScale = 15 / 2;
                } else
                {
                    rigidBody.gravityScale = 1;
                }
            }
            int _score = theScoreManager.Score;
            int _subMoveSpeed = 1;
            if (Input.GetAxisRaw("Attack") != 0)
            {
                Debug.Log("Attack button hit");

                if (!attack_AxisInUse)
                {
                    Debug.Log("Axis not in use");
                    //No Powerup
                    if (_score > 0)
                    {
                        anim.SetTrigger("attack");
                        Debug.Log("Has no powerup");
                        GameObject fireBallClone = (GameObject)Instantiate(fireBall, throwPoint.position, throwPoint.rotation);
                        fireBallClone.transform.localScale = transform.localScale;
                        anim.SetTrigger("Attack");
                        if (isGrounded)
                        {
                            rigidBody.velocity = new Vector2(0, 0);
                        }
                        theScoreManager.Score -= 1;
                        moveSpeed += _subMoveSpeed;
                        _lastMoveSpeed += _subMoveSpeed;
                        jumpForce += _subMoveSpeed;

                        /*if (fireBallClone.GetComponent<Weapon_Gold>().destroy == true)
                        {
                            Destroy(fireBallClone);
                        }*/
                    }
                    attack_AxisInUse = true;
                }
            }
            else if (Input.GetAxisRaw("Attack") == 0)
            {
                attack_AxisInUse = false;
            }
           
            if (rigidBody.velocity.x < 0)
            {
                transform.localScale = new Vector3(_playerX, _playerY, _playerZ);
            }
            else if (rigidBody.velocity.x > 0)
            {
                transform.localScale = new Vector3(-_playerX, _playerY, _playerZ);
            }

            if(rigidBody.velocity.y > 0)
            {
                anim.SetBool("isMoving", false);
                anim.SetBool("isJumping", true);
                anim.SetBool("isFalling", false);
            } else if (rigidBody.velocity.y < 0)
            {
                anim.SetBool("isMoving", false);
                anim.SetBool("isJumping", false);
                anim.SetBool("isFalling", true);
            } else
            {
                anim.SetBool("isJumping", false);
                anim.SetBool("isFalling", false);
            }

            anim.SetFloat("Speed", Mathf.Abs(rigidBody.velocity.x));
            anim.SetBool("Grounded", isGrounded);
        }
    }

    /*public void TripleShot()
    {
        hasPowerup = true;
        tripleShot = true;
    }

    public void BigShot()
    {
        hasPowerup = true;
        bigShot = true;
    }*/
}