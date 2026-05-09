using System.Collections.Generic;
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
    public List<GameObject> obstacles = new List<GameObject>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void SpawnLane(float zOffset)
    {
        if (obstacles.Count == 0) return;

        float xOffset = (3.33f * (int)laneType) - 3.33f;
        GameObject newLane = Instantiate(obstacles[Random.Range(0, obstacles.Count)], new Vector3(xOffset, 0, 12.4f), Quaternion.identity, transform);

    }

    // Update is called once per frame
    void Update()
    {
        foreach (Transform child in transform)
        {
            child.Translate(5f * Time.deltaTime * -Vector3.forward);
        }
    }
}
