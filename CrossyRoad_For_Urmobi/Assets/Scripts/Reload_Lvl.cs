using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reload_Lvl : MonoBehaviour
{
    public ParticleSystem myPS;
    public bool IsDead;

    public void Reload()
    {
        IsDead = true; // make sure that player can't increase score after death
        transform.parent = null;
        StartCoroutine(Wait());
        myPS.Play();
    }
    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(0);
    }
}
