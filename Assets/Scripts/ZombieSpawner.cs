using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    public Transform[] spawnpoints;
    public GameObject zombie;

    private void Start()
    {
        InvokeRepeating("SpawnZombie", 2, 1);
    }
    void SpawnZombie()
    {
        int r = Random.Range(0,spawnpoints.Length);
        GameObject myZombie = Instantiate(zombie, spawnpoints[r].position,Quaternion.identity);
    }
    
}
