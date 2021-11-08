using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeartRemover : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger loss of 1 Heart")]
    [SerializeField] string triggeringTag;
    [SerializeField] GameObject[] hearts;
    [SerializeField] public int life;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag && enabled) {
            Debug.Log("Lost a Heart!");
            TakeDamage(1);
            if(life < 1){
                // hearts[0].gameObject.SetActive = false;
                ToggleVisibility(hearts[0]);
                Debug.Log("Game over!");
                // Application.Quit();
                SceneManager.LoadScene("level-Lost");
                ToggleVisibility(gameObject);
            }
            else if(life < 2){
                // Destroy(hearts[1].gameObject);
                ToggleVisibility(hearts[1]);
            } 
            else if(life < 3){
                // Destroy(hearts[2].gameObject);
                ToggleVisibility(hearts[2]);
            }
        }
    }
    public void TakeDamage(int dmg){
        life -= dmg;
    }
    public void ToggleVisibility(GameObject g)
    {
        Renderer rend = g.GetComponent<Renderer>();
        if(rend.enabled)
        {
            rend.enabled = false;
            Debug.Log("Reducing a Heart");
        }
        else
        {
            rend.enabled = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
