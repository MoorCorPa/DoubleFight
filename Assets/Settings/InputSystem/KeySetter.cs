using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class KeySetter : MonoBehaviour
{
    /**
     此类用于对按键的修改操作
     */
    public static PlayerControl input;

    public static event Action BindComplete;
    public static event Action BindCancel;
    public static event Action<InputAction, int> BindStart;

    private void Awake()
    {
        if (input == null) input = new PlayerControl();
    }
}
