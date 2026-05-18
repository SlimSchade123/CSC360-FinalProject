using UnityEngine;

public class GameState : IState
{
    public void Enter()
    {
        Debug.Log("Playing Game");
        Time.timeScale = 1f;
    }

    public void Exit()
    {
        Debug.Log("Exiting Game");
        Time.timeScale = 0f;
    }
}
