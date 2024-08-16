using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{
    public float health = 50f;

    public void TakeDamage(float amount)
    {
        health -= amount;
        Debug.Log(health);

        if(health <= 0f)
        {
            eatPickle();
        }
    }

    void eatPickle()
    {
        Destroy(gameObject);
    }

}
