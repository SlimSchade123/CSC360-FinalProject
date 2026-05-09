using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    [SerializeField] PlayerController playerController;
    [SerializeField] GroundManager groundManager;

    public static GameManager GetInstance()
    {
        if (GameManager.instance == null)
        {
            GameManager.instance = GameObject.Find("GameManager").GetComponent<GameManager>();
        }
        return GameManager.instance;
    }

    public void SpawnGround()
    {
        groundManager.SpawnGround();
    }
}
