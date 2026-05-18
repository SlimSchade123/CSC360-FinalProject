using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    [SerializeField] PlayerController playerController;
    [SerializeField] GroundManager groundManager;
    [SerializeField] StateManager stateManager;

    [Header("Game Settings")]
    public int initialGroundCount = 5;
    public int groundSpawnThreshold = 10;
    public int movementSpeed = 5;

    public void Awake()
    {
        if (GameManager.instance == null)
        {
            GameManager.instance = this;
        }
        for(int i = 1; i < 5; i++)
        {
            groundManager.SpawnGround();
        }
    }

    public static GameManager GetInstance()
    {
        if (GameManager.instance == null)
        {
            GameManager.instance = GameObject.Find("GameManager").GetComponent<GameManager>();
        }
        return GameManager.instance;
    }

    public void SpawnGround(int prevDepth)
    {
        if (!groundManager.HasLaneInDepthTriggered(prevDepth))
        {
            groundManager.SpawnGround();
            Debug.Log("TRIGGERED");
        }
    }

    public void StartGame()
    {
        stateManager.ChangeState(new GameState());
    }
}
