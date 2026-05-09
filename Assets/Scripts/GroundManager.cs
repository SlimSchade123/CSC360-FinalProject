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

    public void SpawnGround()
    {
        laneDepthCount++;
        foreach (LaneManager lane in lanes)
        {
            lane.SpawnLane(laneDepthCount);
        }

    }
}
