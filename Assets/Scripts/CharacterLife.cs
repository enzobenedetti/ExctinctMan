using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterLife : MonoBehaviour
{
    public int health = 5;

    public float bufferTime = 3f;

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log(other.transform.name);
        if (other.transform.CompareTag("Fire"))
        {
            health--;
        }
    }
}
