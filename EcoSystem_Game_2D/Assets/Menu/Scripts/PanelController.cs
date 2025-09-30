using UnityEngine;

public class PanelController : MonoBehaviour
{
    public GameObject panelDialogo;

    public void TogglePanel()
    {
        if (panelDialogo != null)
        {
            // Alterna entre activo e inactivo
            panelDialogo.SetActive(!panelDialogo.activeSelf);
        }
        else
        {
            Debug.LogWarning("No se ha asignado un panel en el inspector.");
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
