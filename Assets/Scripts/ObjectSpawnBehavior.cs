using UnityEngine;

public class ObjectSpawnBehavior : MonoBehaviour
{
    public GameObject[] spawnObjects;
    public float spawnTimer = 0f;

    void Update() 
    {
        spawnTimer = spawnTimer - Time.deltaTime;
        if(spawnTimer <= 0f) 
        {
            SpawnObject();
            spawnTimer = Random.Range(4f, 6f);
        }
    }

    void SpawnObject()
    {
        //Create Object
        Vector3 randomPosition = transform.position;
        randomPosition = randomPosition + Random.Range(-10f, 10f) * transform.right;

        GameObject newObject = Instantiate(spawnObjects[0], randomPosition, transform.rotation);
        //Position Object
        //Rotate Object
    }
}
