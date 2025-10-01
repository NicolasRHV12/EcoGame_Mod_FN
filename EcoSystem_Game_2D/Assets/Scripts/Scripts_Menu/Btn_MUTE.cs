using UnityEngine;

public class Btn_MUTE : MonoBehaviour
{
    public void OnMuteButtonPressed()
    {
        MusicManager manager = FindObjectOfType<MusicManager>();
        if (manager != null)
        {
           manager.ToggleMute();
        }
        else
        {
            Debug.LogWarning("No se encontró el MusicManager en la escena.");
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
