using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayer : MonoBehaviour
{
    private const double maxHealth = 100;
    public double basehealth;
    public int playerInt = 0;

    private PlayerControl control;

    virtual public void OnEnable()
    {
        control = KeySetter.input;
    }

    virtual public void Start()
    {
        basehealth = maxHealth;
    }

    virtual public void OnMove()
    {
        if (basehealth <= 0) return;
    }

    virtual public void OnJump()
    {

    }

    virtual public void OnAttack()
    {

    }

    virtual public void OnORa()
    {

    }

    virtual public void OnUlt()
    {

    }
}
