using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MasterGameManager : MonoBehaviour
{
    public int level;
    public void LoadNextLevel()
    {
        level = SceneManager.GetActiveScene().buildIndex ;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
