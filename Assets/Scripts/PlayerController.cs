using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerControls Inputs;
    public Rigidbody2D rb;
    public bool isPlatformer;
    public bool Jumping;
    public float JumpForce;
    public float MovementSpeed;
    public int State;
    public int Mode;
    public GameObject HeadObject;
    public GameObject BodyObject;

    private void Awake()
    {
        Inputs = new PlayerControls();
    }

    private void OnEnable()
    {
        Inputs.Enable();
    }

    private void OnDisable()
    {
        Inputs.Disable();
    }

    public void Start()
    {
        if (isPlatformer)
        {
            Inputs.Platformer.Jump.performed += _ => Jump();
        }
    }

    public void Update()
    {
        Move();
        UpdateAnimations();
    }

    public void Move()
    {
        float H_Movement = Inputs.Default.H_Movement.ReadValue<float>();
        float V_Movement = Inputs.TopDown.V_Movement.ReadValue<float>();
        if (H_Movement < 0)
        {
            H_Movement -= MovementSpeed;
            HeadObject.GetComponent<SpriteRenderer>().flipX = true;
            BodyObject.GetComponent<SpriteRenderer>().flipX = true;
            if (!Jumping)
            {
                State = 1;
            }
        }
        else if (H_Movement > 0)
        {
            H_Movement = MovementSpeed;
            HeadObject.GetComponent<SpriteRenderer>().flipX = false;
            BodyObject.GetComponent<SpriteRenderer>().flipX = false;
            if (!Jumping)
            {
                State = 1;
            }
        }
        else
        {
            H_Movement = 0;
            if (!Jumping)
            {
                State = 0;
            }
        }

        if (isPlatformer)
        {
            rb.velocity = new Vector2(H_Movement, rb.velocity.y);
        }
        else
        {
            if (V_Movement < 0)
            {
                V_Movement -= MovementSpeed;
                State = 1;
            }
            else if (V_Movement > 0)
            {
                V_Movement = MovementSpeed;
                State = 1;
            }
            else
            {
                V_Movement = 0;
                State = 0;
            }
            rb.velocity = new Vector2(H_Movement, V_Movement);
        }
    }
    public void Jump()
    {
        if (Jumping == false)
        {
            rb.velocity = new Vector2(rb.velocity.x, JumpForce);
            Jumping = true;
            State = 2;
        }
    }
    public void UpdateAnimations()
    {
        BodyObject.GetComponent<Animator>().SetInteger("State", State);
    }
}
