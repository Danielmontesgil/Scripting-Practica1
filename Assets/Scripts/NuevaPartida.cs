using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NuevaPartida : MonoBehaviour {

	void Update () {
	    if(Input.GetMouseButton(0))
            SceneManager.LoadScene("_Juego");
    }
}
