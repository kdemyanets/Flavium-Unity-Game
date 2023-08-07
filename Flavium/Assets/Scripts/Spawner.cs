using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UI.Image;

public class Spawner : MonoBehaviour
{
    public GameObject columnPrefab;
    public float TimeToSpawn, minYPosition, maxYPosition;
    private float timer;

    private void Start()
    {
        timer = TimeToSpawn;

    }

    private void Update()
    {
        if (timer <=0)
        {
            timer = TimeToSpawn;
            GameObject column = Instantiate(columnPrefab, transform.position, Quaternion.identity);
            float rand = Random.Range(minYPosition, maxYPosition);
            column.transform.position=new Vector3(column.transform.position.x, rand, 0);

            Destroy(column, 5.0f);
        }

        else
        {
            timer -= Time.deltaTime;
        }
    }

}
