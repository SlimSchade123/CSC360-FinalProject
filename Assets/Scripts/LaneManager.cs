using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public enum LaneType
{
    Left,
    Center,
    Right
}

public class LaneManager : MonoBehaviour
{
    public LaneType laneType;
    [SerializeField] List<GameObject> obstacles = new();
    [SerializeField] List<GameObject> spawnedObstacles = new();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
 
    public GameObject? GetRandomObstacle()
    {
        if (obstacles.Count == 0) return null;
        return obstacles[Random.Range(0, obstacles.Count)];
    }

    public GameObject? GetFirstObstacle()
    {
        if (obstacles.Count == 0) return null;
        return obstacles[0];
    }

    public void SpawnLane(int depth, GameObject randomObstacle)
    {
        if (obstacles.Count == 0) return;

        float xValue = 0;
        float zValue = 0;
        if (spawnedObstacles.Count > 0)
        {
            GameObject lastObstacle = spawnedObstacles.Last();
            xValue = lastObstacle.transform.position.x;
            zValue = lastObstacle.transform.position.z + 24f;
        }
        
        GameObject newLane = Instantiate(randomObstacle, new Vector3(xValue, 0, zValue), Quaternion.Euler(0, 90, 0), transform);
        LaneTrigger laneTrigger = newLane.GetComponentInChildren<LaneTrigger>();
        if (laneTrigger != null)
        {
            Debug.Log(depth);
            laneTrigger.depth = depth;
        }
        spawnedObstacles.Add(newLane);
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Transform child in transform)
        {
            child.Translate(GameManager.GetInstance().movementSpeed * Time.deltaTime * Vector3.right);
        }
    }
}
