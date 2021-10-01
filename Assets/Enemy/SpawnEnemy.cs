using UnityEngine;

public class SpawnEnemy : MonoBehaviour 
{
    private float TimeSpawn;
    [SerializeField] private GameObject zombie;
    private void Update()
    {
        Spawn();
    }

    private void Spawn()
    {
        TimeSpawn += Time.deltaTime;
        if (TimeSpawn > 3.0f)
        {
            Instantiate(zombie);
            zombie.transform.position = transform.position;
            TimeSpawn = 0f;
        }
                     
  
    }
}
