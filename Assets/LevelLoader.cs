using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class LevelLoader : MonoBehaviour
{
    public GameObject loadingScreen;
    public Slider slider;
    public TMP_Text progressText;
    public Animator animator;

    void Update()
    {
        if (slider.value == 100)
        {
            animator.SetTrigger("Start");
        }
    }
    public void LoadLevel(int SceneIndex)
    {

        StartCoroutine(LoadAsyncronusly(SceneIndex));
    }
    IEnumerator LoadAsyncronusly(int SceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(SceneIndex);

        loadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            slider.value = progress;
            progressText.text = progress * 100 + "%";

            yield return null;
        }
    }
        
        
}
