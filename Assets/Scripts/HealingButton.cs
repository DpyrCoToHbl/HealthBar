using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingButton : MonoBehaviour
{
    public void Healing(Health health)
    {
        if (health.CurrentHealth + health.VariableValue <= health.MaxHealth)
        {
            health.CurrentHealth += health.VariableValue;
        }
    }
}
