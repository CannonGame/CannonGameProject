using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShieldHealth : MonoBehaviour
{
    public EnergyBar energyBar;

    //Start is called before the first frame update
    void Start()
    {
        energyBar.energyBar.value = energyBar.CalculateEnergy();
    }

    // Heals Energy Shield based on difficulty upon collision.
    void OnTriggerEnter2D(Collider2D col)
    {
        energyBar.HealShield(EnergyBar.heal);
    }
}
