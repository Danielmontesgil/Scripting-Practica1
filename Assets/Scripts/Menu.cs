using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    [SerializeField]
    private GameObject[] menu;
	
    void Start () {
        menu[0].SetActive(true);
        menu[1].SetActive(false);
	}
	
    public void NuevaPartida()
    {
        SceneManager.LoadScene("_Juego");
    }
    
    public void Instrucciones()
    {
        menu[0].SetActive(false);
        menu[1].SetActive(true);
    } 

    public void Atras()
    {
        menu[0].SetActive(true);
        menu[1].SetActive(false);
    }

    public void Salir()
    {
        Application.Quit();
    }
}
