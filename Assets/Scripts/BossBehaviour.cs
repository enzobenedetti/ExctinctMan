using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class BossBehaviour : MonoBehaviour, IFire
{
    public int health = 500;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoseHealth()
    {
        health--;
        if (health <= 0)
        {
            Debug.Log("Die");
        }
    }
}
