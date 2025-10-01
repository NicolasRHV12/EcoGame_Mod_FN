using UnityEngine;
using UnityEngine.SceneManagement;

public class Btn_volver : MonoBehaviour
{
    public string nombreMenu = "Menu";


    public void RegresarAlMenu()
    {
        SceneManager.LoadScene("1Menu");
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
