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
    }

    public void Move()
    {
        float H_Movement = Inputs.Default.H_Movement.ReadValue<float>();
        float V_Movement = Inputs.TopDown.V_Movement.ReadValue<float>();
        if (H_Movement < 0)
        {
            H_Movement -= MovementSpeed;
        }
        else if (H_Movement > 0)
        {
            H_Movement = MovementSpeed;
        }
        else
        {
            H_Movement = 0;
        }

        if (V_Movement < 0)
        {
            V_Movement -= MovementSpeed;
        }
        else if (V_Movement > 0)
        {
            V_Movement = MovementSpeed;
        }
        else
        {
            V_Movement = 0;
        }

        if(isPlatformer){
            rb.velocity = new Vector2(H_Movement, rb.velocity.y);
        }
        else{
            rb.velocity = new Vector2(H_Movement, V_Movement);
        }
    }
    public void Jump()
    {
        if (Jumping == false)
        {
            rb.velocity = new Vector2(rb.velocity.x, JumpForce);
            Jumping = true;
        }
    }
}
