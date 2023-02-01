using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayer : MonoBehaviour
{
    const double maxHealth = 100;
    double basehealth;

    virtual public void Start()
    {
        basehealth= maxHealth;
    }

    virtual public void movement()
    {
        if (basehealth <= 0) return;
    }

    virtual public void jump()
    {

    }

    virtual public void attack()
    {

    }

    virtual public void ora()
    {

    }

    virtual public void ult()
    {

    }
}
