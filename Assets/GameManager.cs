using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class GameManager : MonoBehaviour
{

    public CharacterController2D player;

    public int coinsCounter = 0;
    public Text coinText;

    void Update()
    {
        coinText.text = coinsCounter.ToString();

        if (player.deathState == true)
        {
            // Reload the scene after 0.1 seconds
            Invoke("ReloadLevel", 0.1f);
        }
    }

    
   

    
    

    private void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}


