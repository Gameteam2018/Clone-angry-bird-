using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour {
    public float health = 4f;
    void OnCollisionEnter2D (Collision2D enemybird)
    {
        Debug.Log(enemybird.relativeVelocity.magnitude);
          if ( enemybird.relativeVelocity.magnitude>health)
            {
                Die();
            }
    }
    void Die()
    {
        Destroy(gameObject);
    }
}
