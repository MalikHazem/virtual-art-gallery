using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermov : MonoBehaviour
{
    /*NetworkBehaviour*/
    
    public float speed = 5f;
    public float runspeed = 9f;
    public float backrunspeed = 7f;
    public float gravity = 20f;
    public float jump = 6f;
    public float rotspeed = 60f;

    CharacterController controller;
    Animator anim;

    float horizontal;
    float vertical;
    float rot = 0f;

    Vector3 moveDirection = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        #region Move
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(horizontal, 0.0f, vertical);
            if(moveDirection !=Vector3.zero && !Input.GetKey(KeyCode.E))
            {
                moveDirection *= speed; 
            }
            else if (moveDirection != Vector3.zero && Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.E))
            {
                anim.SetBool("isRuning", true);
                anim.SetBool("isWalking", false);
                anim.SetBool("isWalkJump", false);
                moveDirection *= runspeed;
            }
            else if (moveDirection != Vector3.zero && Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.E))
            {
                anim.SetBool("isBackRun", true);
                anim.SetBool("isWalkBack", false);
                anim.SetBool("isBackJump", false);
                moveDirection *= backrunspeed;
            }
            moveDirection = transform.TransformDirection(moveDirection);
            #endregion

            #region Jump
            if (Input.GetButtonDown("Jump"))
                {
                anim.SetBool("isJumping", true);
                /*moveDirection.y = jump;*/
            }
            else
            {
                anim.SetBool("isJumping", false);
            }
            #endregion

            #region Walk
            bool w = Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W);
            bool s = Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S);
            bool d = Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D);
            bool a = Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A);

            #region Walk
            if (w)
            {   
                if (Input.GetButton("Jump"))
                {
                    anim.SetBool("isWalkJump", true);
                    
                }
                /*else if (Input.GetKey(KeyCode.E) && !Input.GetButton("Jump"))
                {
                    anim.SetBool("isRuning", true);
                    anim.SetBool("isWalking", false);
                    anim.SetBool("isWalkJump", false);
                }*/
                else if (!Input.GetKey(KeyCode.E) && !Input.GetButton("Jump"))
                {
                    anim.SetBool("isWalking", true);
                    anim.SetBool("isWalkJump", false);
                    anim.SetBool("isRuning", false);
                }
            }
            else
            {
                anim.SetBool("isWalking", false);
                anim.SetBool("isWalkJump", false);
                anim.SetBool("isRuning", false);
            }
            #endregion

            #region Walk Back
            if (s)
            {
                if (Input.GetButton("Jump"))
                {
                    anim.SetBool("isBackJump", true);
                }
                /*else if (Input.GetKey(KeyCode.E) && !Input.GetButton("Jump"))
                {
                    anim.SetBool("isBackRun", true);
                    anim.SetBool("isWalkBack", false);
                    anim.SetBool("isBackJump", false);
                }*/
                else if (!Input.GetKey(KeyCode.E) && !Input.GetButton("Jump"))
                {
                    anim.SetBool("isWalkBack", true);
                    anim.SetBool("isBackJump", false);
                    anim.SetBool("isBackRun", false);
                }
            }
            else
            {
                anim.SetBool("isWalkBack", false);
                anim.SetBool("isBackJump", false);
                anim.SetBool("isBackRun", false);
            }
            #endregion

            #region Walk Right
            if (d)
            {
                if (w && !s)
                {
                    if (Input.GetButton("Jump"))
                    {
                        anim.SetBool("isWalkJump", true);
                        anim.SetBool("isWalkRight", false);
                    }
                    else if (Input.GetKey(KeyCode.E) && !Input.GetButton("Jump"))
                    {
                        anim.SetBool("isRuning", true);
                        anim.SetBool("isWalking", false);
                        anim.SetBool("isWalkRight", false);
                        anim.SetBool("isWalkJump", false);
                    }
                    else if (!Input.GetKey(KeyCode.E) && !Input.GetButton("Jump"))
                    {
                        anim.SetBool("isWalking", true);
                        anim.SetBool("isWalkJump", false);
                        anim.SetBool("isRuning", false);
                        anim.SetBool("isWalkRight", false);
                    }
                }
                else if (s && !w)
                {
                    if (Input.GetButton("Jump"))
                    {
                        anim.SetBool("isBackJump", true);
                        anim.SetBool("isWalkRight", false);
                    }
                    else if (Input.GetKey(KeyCode.E) && !Input.GetButton("Jump"))
                    {
                        anim.SetBool("isBackRun", true);
                        anim.SetBool("isWalkBack", false);
                        anim.SetBool("isBackJump", false);
                        anim.SetBool("isWalkRight", false);
                    }
                    else if (!Input.GetKey(KeyCode.E) && !Input.GetButton("Jump"))
                    {
                        anim.SetBool("isWalkBack", true);
                        anim.SetBool("isBackJump", false);
                        anim.SetBool("isBackRun", false);
                        anim.SetBool("isWalkRight", false);
                    }
                }
                else if (!w && !s)
                {
                    anim.SetBool("isWalkRight", true);
                    anim.SetBool("isWalking", false);
                    anim.SetBool("isWalkJump", false);
                    anim.SetBool("isRuning", false);
                    anim.SetBool("isWalkBack", false);
                    anim.SetBool("isBackJump", false);
                    anim.SetBool("isBackRun", false);
                }
                
            }
            else
            {
                anim.SetBool("isWalkRight", false);
            }
            #endregion

            #region Walk Left
            if (a)
            {
                if (w && !s)
                {
                    if (Input.GetButton("Jump"))
                    {
                        anim.SetBool("isWalkJump", true);
                        anim.SetBool("isWalkLeft", false);
                    }
                    else if (Input.GetKey(KeyCode.E) && !Input.GetButton("Jump"))
                    {
                        anim.SetBool("isRuning", true);
                        anim.SetBool("isWalking", false);
                        anim.SetBool("isWalkLeft", false);
                        anim.SetBool("isWalkJump", false);
                    }
                    else if (!Input.GetKey(KeyCode.E) && !Input.GetButton("Jump"))
                    {
                        anim.SetBool("isWalking", true);
                        anim.SetBool("isWalkJump", false);
                        anim.SetBool("isRuning", false);
                        anim.SetBool("isWalkLeft", false);
                    }
                }
                else if (s && !w)
                {
                    if (Input.GetButton("Jump"))
                    {
                        anim.SetBool("isBackJump", true);
                        anim.SetBool("isWalkLeft", false);
                    }
                    else if (Input.GetKey(KeyCode.E) && !Input.GetButton("Jump"))
                    {
                        anim.SetBool("isBackRun", true);
                        anim.SetBool("isWalkBack", false);
                        anim.SetBool("isBackJump", false);
                        anim.SetBool("isWalkLeft", false);
                    }
                    else if (!Input.GetKey(KeyCode.E) && !Input.GetButton("Jump"))
                    {
                        anim.SetBool("isWalkBack", true);
                        anim.SetBool("isBackJump", false);
                        anim.SetBool("isBackRun", false);
                        anim.SetBool("isWalkLeft", false);
                    }
                }
                else if (!w && !s)
                {
                    anim.SetBool("isWalkLeft", true);
                    anim.SetBool("isWalking", false);
                    anim.SetBool("isWalkJump", false);
                    anim.SetBool("isRuning", false);
                    anim.SetBool("isWalkBack", false);
                    anim.SetBool("isBackJump", false);
                    anim.SetBool("isBackRun", false);
                }
            }
            else
            {
                anim.SetBool("isWalkLeft", false);
            }
            #endregion
            #endregion

            #region Dance
            if (Input.GetKey(KeyCode.K))
            {
                anim.SetBool("isDanceing", true);
            }
            else
            {
                anim.SetBool("isDanceing", false);
            }
            #endregion

            }
        /*rot += Input.GetAxis("Horizontal") *rotspeed *Time.deltaTime;
        transform.eulerAngles = new Vector3(0, rot, 0);*/

        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }
}


