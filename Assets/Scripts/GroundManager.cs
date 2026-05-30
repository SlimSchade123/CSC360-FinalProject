using System.Collections.Generic;
using UnityEngine;

public class GroundManager : MonoBehaviour
{
    public int laneDepthCount = 1;
    public List<LaneManager> lanes = new List<LaneManager>();
    public LaneFactory laneFactory;

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
        laneFactory.SpawnGround(lanes, ref laneDepthCount);
    }
}
