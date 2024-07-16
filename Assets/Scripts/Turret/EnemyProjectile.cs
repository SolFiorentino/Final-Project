using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    public float damage = 10f;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Reducir la vida del jugador
            LifeBarController playerLife = collision.gameObject.GetComponent<LifeBarController>();
            if (playerLife != null)
            {
                playerLife.TakeDamage(damage);
            }

            // Destruir el proyectil al impactar
            Destroy(gameObject);
        }
        else
        {
            // Destruir el proyectil al impactar con cualquier otro objeto
            Destroy(gameObject);
        }
    }
}

