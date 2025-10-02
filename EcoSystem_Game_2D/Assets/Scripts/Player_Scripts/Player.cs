using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [Header("Configuración del Player")]
    public int vidas = 3;

    [Header("UI - Corazones")]
    public Image[] corazones; // arrastra aquí las imágenes de corazones (3 en tu caso)
    
    public void RecibirDaño(int cantidad)
    {
        vidas -= cantidad;

        if (vidas < 0) vidas = 0; 

        // 🔴 Actualiza corazones según vidas
        for (int i = 0; i < corazones.Length; i++)
        {
            if (i < vidas)
                corazones[i].gameObject.SetActive(true); // Corazón visible
            else
                corazones[i].gameObject.SetActive(false); // Corazón eliminado
        }

        Debug.Log("Recibió daño, le quedan " + vidas + " vidas.");

        if (vidas <= 0)
        {
            Debug.Log("¡El jugador ha muerto! Cargando Game Over...");
            SceneManager.LoadScene("5Game_Over"); // 👈 Asegúrate que exista esa escena
        }
    }
}