using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    #region Text Variables
    //private int pickUpCount;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;
   
    #endregion
    #region Game State Variables
    
    public float restartDelay = 2f;
    #endregion

    private void Start()
    {
        winTextObject.SetActive(false);
        
    }
    

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void setCountText(int count)
    {
        countText.text = count.ToString();
        if (count == 1)
        {
            winTextObject.SetActive(true);
        }

        
    }



}