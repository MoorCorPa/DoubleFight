using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BasePlayer : MonoBehaviour
{
    private const double maxHealth = 100;
    public double basehealth;

    public PlayerControl control;

    virtual public void OnEnable()
    {
        control = KeySetter.input;
        if (control == null) control = new PlayerControl();
    }

    virtual public void Start()
    {
        basehealth = maxHealth;
    }

    virtual public void Update()
    {
        if (basehealth <= 0) OnDead();
    }

    virtual public void OnMove(InputAction.CallbackContext context)
    {
        transform.Translate(context.ReadValue<Vector2>());
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
