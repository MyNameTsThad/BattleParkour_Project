
using UnityEngine;

public class TimerManager : MonoBehaviour
{
    public float slowDownModifer = 0.05f;
    public float slowdownLength = 2f;
    PlayerMovement player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        Time.timeScale += (1f / slowdownLength) * Time.unscaledDeltaTime;

        Time.timeScale = Mathf.Clamp(Time.timeScale, 0f, 1f);


        if (Time.timeScale == 1)
        {
            player.runSpeed /= 2;
        }
    }
    public void SlowMotion()
    {
        Time.timeScale = slowDownModifer;
        Time.fixedDeltaTime = Time.timeScale * .02f;
        player.runSpeed *= 2;
    }

}
