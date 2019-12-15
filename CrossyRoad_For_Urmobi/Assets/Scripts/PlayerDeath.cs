using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public Reload_Lvl myParticleSystem;
    private void OnTriggerEnter(Collider other)
    {
        Death();
    }
  
    private void OnBecameInvisible()
    {
        Death();
    }
    private void Death()
    {
        myParticleSystem.Reload();
        Destroy(gameObject);
    }
}
