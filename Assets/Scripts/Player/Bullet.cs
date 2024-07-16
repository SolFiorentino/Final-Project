using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // Verifica si la colisi�n es con una caja
        if (collision.gameObject.CompareTag("Box"))
        {
            // Aqu� puedes manejar lo que sucede cuando la bala colisiona con una caja
            Debug.Log("La bala impact� con una caja!");

            // Incrementar el contador de objetivos impactados
            ScoreManager.instance.IncrementScore();

            // Destruir la bala al colisionar
            Destroy(gameObject);
        }
    }
}


