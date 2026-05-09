using UnityEngine;

public class LaneTrigger : MonoBehaviour
{
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
        Debug.Log("TRIGGERED");
        if (other.CompareTag("Player"))
        {
            GameManager.GetInstance().SpawnGround();
        }
    }
}
