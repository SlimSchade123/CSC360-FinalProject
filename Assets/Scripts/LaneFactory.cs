using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class LaneFactory : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnGround(List<LaneManager> lanes, ref int laneDepthCount)
    {
        bool validPath = false;
        laneDepthCount++;
        for (int i = 0; i < lanes.Count; i++)
        {
            LaneManager lane = lanes[i];
            GameObject? randomObstacle = lane.GetRandomObstacle();

            if (randomObstacle != null)
            {
                if (!randomObstacle.name.Contains("Empty"))
                {
                    validPath = true;
                }
                if (i == lanes.Count - 1 && !validPath)
                {
                    lane.SpawnLane(laneDepthCount, lane.GetFirstObstacle());
                }
                else
                {
                    lane.SpawnLane(laneDepthCount, randomObstacle);
                }
            }
        }
    }
}
