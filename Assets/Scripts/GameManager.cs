using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    [SerializeField] PlayerController playerController;


    public static GameManager GetInstance()
    {
        if (GameManager.instance == null)
        {
            GameManager.instance = GameObject.Find("GameManager").GetComponent<GameManager>();
        }
        return GameManager.instance;
    }

    
}
