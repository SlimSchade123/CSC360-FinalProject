using System.Collections.Generic;
using UnityEngine;

public class GroundManager : MonoBehaviour
{
    public int laneDepthCount = 1;
    public List<LaneManager> lanes = new List<LaneManager>();

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool HasLaneInDepthTriggered(int depth)
    {
        bool hasTriggered = false;
        foreach (LaneManager lane in lanes)
        {
            foreach (Transform child in lane.transform)
            {
                LaneTrigger trigger = child.GetComponentInChildren<LaneTrigger>();
                if (trigger != null && trigger.depth == depth)
                {
                    
                    if (trigger.triggered) hasTriggered = true;
                }
            }
        }
        return hasTriggered;
    }

    public void SpawnGround()
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
