using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnEnableDisable_Truck : MonoBehaviour
{
    private float lifetime;
    public float speed = 5f;   
    private void OnEnable()
    {
        // make sure that truck will be in pool when it needed    
        lifetime = 1f * 4.9f;//TruckSpawner.minSpawnTime * TruckSpawner.poolCount;
        speed = 5f + transform.position.y * 0.1f;// increasing speed
        Invoke("Deactive", lifetime);
    }
    private void OnDisable()
    {
        CancelInvoke();
    }
    private void Update()
    {
        transform.Translate(-speed * Time.deltaTime, 0, 0);
    }
    void Deactive()
    {
        gameObject.SetActive(false);
    }
}
