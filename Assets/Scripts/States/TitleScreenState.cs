using UnityEngine;

public class TitleScreenState : IState
{
    private GameObject titleScreen;
    public void Enter()
    {
        titleScreen = GameObject.Find("Canvas/TitleScreen");
        titleScreen.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Exit()
    {
        titleScreen.SetActive(false);
    }
}
