using UnityEngine;
public class StateManager : MonoBehaviour
{
    private IState currentState;

    private void Start()
    {
        // Initialize the first state, e.g., TitleScreenState
        currentState = new TitleScreenState();
        currentState.Enter();
    }

    public void ChangeState(IState newState)
    {
        if (currentState == newState) return;

        currentState.Exit();
        currentState = newState;
        currentState.Enter();
    }
}
