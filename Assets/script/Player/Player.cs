using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterController cc;
    public float moveSpeed = 4;
    public float jumpSpeed = 5;

    private float horzonMove, verticalMove;
    private Vector3 dir;

    public float grav = 10;
    private Vector3 vel;

    public Transform groundCk;
    public float checkRa;
    public LayerMask groundLayer;
    public bool isGround;

    private void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        isGround = Physics.CheckSphere(groundCk.position, checkRa, groundLayer);
        if (isGround && vel.y < 0)
        {
            vel.y = -3f;
        }

        horzonMove = Input.GetAxis("Horizontal") * moveSpeed;
        verticalMove = Input.GetAxis("Vertical") * moveSpeed;

        dir = transform.forward * verticalMove + transform.right * horzonMove;
        cc.Move(dir * Time.deltaTime);

        if (Input.GetButtonDown("Jump"))
        {
            vel.y = jumpSpeed;
        }

        vel.y -= grav * Time.deltaTime;
        cc.Move(vel * Time.deltaTime);
    }
}
