using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public void StartNewGame()
    {
        SceneManager.LoadScene("level-1");
        // HeartRemover.life = 3;
        Renderer rend =  gameObject.GetComponent<Renderer>();
        rend.enabled = true;
    }
}
