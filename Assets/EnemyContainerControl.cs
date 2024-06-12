using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyContainerControl : MonoBehaviour
{
    public GameObject prefabEnemy;
    public float minXPosition;
    public float maxXPosition;
    public float yPosition;
    void Start()
    {
        CreateEnemy();
    }
    void CreateEnemy()
    {
        float xPosition = Random.Range(minXPosition, maxXPosition );
        Vector2 positionToCreate = new Vector2(xPosition, yPosition);
        Instantiate(prefabEnemy, positionToCreate, transform.rotation);
        Invoke("CreateEnemy", 2);
    }
}
