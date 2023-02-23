using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BasePlayer : MonoBehaviour
{
    private const double maxHealth = 100;
    private int direction = 1;
    public double baseHealth;
    public float moveSpeed, jumpForce = 2;

    private Vector2 moveVal = new();

    public Rigidbody2D rb;
    public GameObject foot;
    public PlayerControl control;
    private Vector3 baseScale;

    virtual public void OnEnable()
    {
        control = KeySetter.input;
        if (control == null) control = new PlayerControl();
    }

    virtual public void Start()
    {
        baseHealth = maxHealth;
        baseScale = transform.localScale;
    }

    virtual public void Update()
    {
        if (baseHealth <= 0) OnDead();
        MoveHandler();
    }

    virtual public void OnMove(InputAction.CallbackContext context)
    {
        //transform.Translate(context.ReadValue<Vector2>());
        moveVal = context.ReadValue<Vector2>();
    }

    virtual public void MoveHandler()
    {
        if (moveVal.x != 0) 
        {
            direction = moveVal.x > 0 ? 1 : -1;
            rb.velocity = new(direction * moveSpeed, 0);
            transform.localScale = new(direction*baseScale.x, baseScale.y, baseScale.y);
            // transform.localRotation = Quaternion.Euler(0, direction==1?0:180, 0);
        }
    }

    virtual public void OnJump(InputAction.CallbackContext context)
    {

    }

    virtual public void OnAttack(InputAction.CallbackContext context)
    {

    }

    virtual public void OnORa(InputAction.CallbackContext context)
    {

    }

    virtual public void OnUlt(InputAction.CallbackContext context)
    {

    }

    virtual public void OnDead()
    {

    }

    public void BindBlue()
    {
        control.PlayerBlue.Move.performed += OnMove;
        control.PlayerBlue.Jump.performed += OnJump;

        control.PlayerBlue.Move.Enable();
        control.PlayerBlue.Jump.Enable();
    }

    public void BindRed()
    {
        control.PlayerRed.Move.performed += OnMove;
        control.PlayerRed.Jump.performed += OnJump;

        control.PlayerRed.Move.Enable();
        control.PlayerRed.Jump.Enable();
    }
}
