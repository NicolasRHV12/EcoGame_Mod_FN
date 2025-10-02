
using UnityEngine;
using UnityEngine.SceneManagement;


public class PuntoMeta : MonoBehaviour
{
        private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
        
            if (ContadorElementos.instancia != null && 
                ContadorElementos.instancia.elementosBuenos >= ContadorElementos.instancia.totalElementosBuenos)
            {
                Debug.Log("¡Llegó a la meta con todos los elementos! Victoria 🚀");
                SceneManager.LoadScene("6Victory"); 
            }
            else
            {
                Debug.Log("No recolectó todo, no puede ganar aún");
            }
        }
    }
}