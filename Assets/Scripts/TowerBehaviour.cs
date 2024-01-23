using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TowerBehaviour : MonoBehaviour
{
    
    [SerializeField] float fireRate = 3.0f;
    CircleCollider2D enemyDetectionCollider;
    void Start()
    {
        enemyDetectionCollider=GetComponent<CircleCollider2D>();
    }

  
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        return;
    }
}
