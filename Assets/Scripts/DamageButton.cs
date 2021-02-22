using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageButton : MonoBehaviour
{
    public void TakeDamage(Health health)
    {
        if (health.CurrentHealth - health.VariableValue >= 0)
        {
            health.CurrentHealth -= health.VariableValue;
        }
    }
}
