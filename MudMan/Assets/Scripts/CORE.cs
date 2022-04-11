using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CORE : MonoBehaviour
{
    public Transform enemyPrefab;
    public Transform spawnPoint;

    private static List<GameObject> theRooms = new List<GameObject>();

    public static void addRoomGO(GameObject go)
    {
        CORE.theRooms.Add(go);
        print("Added Room");
    }

    public static void display()
    {
        print("Woot");
    }

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 20; i++)
        {
            Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
        }
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
