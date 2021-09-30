using UnityEngine;

public class SpawnEnemy : MonoBehaviour 
{
    private float TimeSpawn;

    private void Update()
    {
        Spawn();
    }

    private void Spawn()
    {
        TimeSpawn += Time.deltaTime;
        if (TimeSpawn > 3.0f)
        {
            Instantiate(GameObject.Find("zombie"));
            TimeSpawn = 0f;
        }
  
    }
}
