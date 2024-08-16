using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;
public class enemySpawn : MonoBehaviour
{
    public int numEnemies = 10;
    public GameObject prefab;
    int originalChildren;
    Transform enemies;

    Random rand = new Random();

    void makeAChild()
    {
        float childX = rand.Next(50);
        float childZ = rand.Next(50);

        GameObject newChild = Instantiate(prefab, new Vector3(childX, 10f, childZ), Quaternion.identity) as GameObject;
        newChild.transform.parent = enemies;
    }

    // Start is called before the first frame update
    void Start()
    {
        enemies = GameObject.Find("Enemies").transform;
        for(int i = 0; i < numEnemies; i++)
        {
            makeAChild();
        }
        originalChildren = transform.childCount;
    }

    // Update is called once per frame
    void Update()
    {
        int currentChildren = transform.childCount;

        if(currentChildren < originalChildren)
        {
            makeAChild();
        }
    }
}
