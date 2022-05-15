using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject deathScreen;
    public GameObject PaSSH;
    public bool IsDeadYet = false;
    
    


    
    
    private void Start()
    {
        
        deathScreen.SetActive(false);
        
    }
    public void EndGame()
    {
        deathScreen.SetActive(true);
        
        
        PaSSH.GetComponent<PointAndShoot>().enabled = false;
        Cursor.visible = true;
        
        

    }
    private void ToggleTime()
    {
        IsDeadYet = !IsDeadYet;
        if (IsDeadYet)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
    public void Respawn()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);


    }
    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }

}
