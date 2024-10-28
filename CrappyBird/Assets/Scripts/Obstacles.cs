using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField] 
    private GameObject upperObstacle;
    [SerializeField]
    private GameObject lowerObstacle;
    private float spawnInterval = 2f;
    private float moveSpeed = 3f;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnObstacles), 0f, spawnInterval);
    }

    private void SpawnObstacles()
    {
        Instantiate(upperObstacle, new Vector3(Camera.main.transform.position.x + 10 , Random.Range(3, 6), 0), Quaternion.identity);
        Instantiate(lowerObstacle, new Vector3(Camera.main.transform.position.x + 10 , Random.Range(-6, -3), 0), Quaternion.identity);
    }

    private void Update()
    {
        MoveObstacles();
    }

    private void MoveObstacles()
    {
        GameObject[] obstacles = GameObject.FindGameObjectsWithTag("Obstacle");

        foreach (GameObject obstacle in obstacles)
        {
            obstacle.transform.Translate(moveSpeed * Time.deltaTime * Vector3.left);

            if (obstacle.transform.position.x < Camera.main.transform.position.x - Camera.main.orthographicSize * 2)
            {
                Destroy(obstacle);
            }
        }
    }
}
