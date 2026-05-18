using UnityEngine;

public class LaneTrigger : MonoBehaviour
{
    public bool triggered = false;
    public int depth;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            GameManager.GetInstance().SpawnGround(depth);
            triggered = true;
        }
    }
}
