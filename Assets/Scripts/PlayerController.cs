using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerControls Inputs;
    public Rigidbody rb;
    public bool Jumping;
    public float JumpForce;
    public float MovementSpeed;
    public int State;
    public int Mode;
    public GameObject HeadObject;
    public GameObject BodyObject;
    public GameObject ShadowObject;
    public Mesh IdleMesh;
    public Mesh JumpingMesh;

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
        Inputs.Platformer.Jump.performed += _ => Jump();
    }

    public void Update()
    {
        Move();
        UpdateAnimations();
    }

    public void Move()
    {
        if (!Jumping)
        {
            ShadowObject.GetComponent<MeshFilter>().mesh = IdleMesh;
        }
        float H_Movement = Inputs.Default.H_Movement.ReadValue<float>();
        float V_Movement = Inputs.TopDown.V_Movement.ReadValue<float>();
        if (H_Movement < 0)
        {
            H_Movement -= MovementSpeed;
            HeadObject.GetComponent<SpriteRenderer>().flipX = true;
            BodyObject.GetComponent<SpriteRenderer>().flipX = true;
            ShadowObject.transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        else if (H_Movement > 0)
        {
            H_Movement = MovementSpeed;
            HeadObject.GetComponent<SpriteRenderer>().flipX = false;
            BodyObject.GetComponent<SpriteRenderer>().flipX = false;
            ShadowObject.transform.localRotation = Quaternion.Euler(0, 180, 0);
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
        rb.velocity = new Vector3(H_Movement, rb.velocity.y, V_Movement);

        if (H_Movement > 0 || H_Movement < 0 || V_Movement > 0 || V_Movement < 0)
        {
            if (!Jumping)
            {
                State = 1;
            }
        }
        else if (H_Movement == 0 && V_Movement == 0)
        {
            if (!Jumping)
            {
                State = 0;
            }
        }
    }
    public void Jump()
    {
        if (Jumping == false)
        {
            rb.velocity = new Vector3(rb.velocity.x, JumpForce, rb.velocity.z);
            Jumping = true;
            ShadowObject.GetComponent<MeshFilter>().mesh = JumpingMesh;
            State = 2;
        }
    }
    public void UpdateAnimations()
    {
        BodyObject.GetComponent<Animator>().SetInteger("State", State);
    }
}
