using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerGame : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("Game"); // Aseg�rate de que el nombre de la escena del juego sea correcto
        
    }

 
}



