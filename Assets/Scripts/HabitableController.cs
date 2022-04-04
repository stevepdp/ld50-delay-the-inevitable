using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HabitableController : MonoBehaviour
{
    public GameObject o_Shuttle;
    
    private bool b_KeepSpawning = true;
    private float f_SpawnTimeLowerRange = 4f;
    private float f_SpawnTimeUpperRange = 10f;

    private void Start()
    {
        // Create a shuttle every x seconds
        StartCoroutine(CreateShuttle());
    }

    IEnumerator CreateShuttle()
    {
        while(b_KeepSpawning)
        {
            // Create shuttle instance
            GameObject o_ShuttleInstance = Instantiate(o_Shuttle);

            // Face the calling planet
            Vector3 targetOffset = transform.position - o_ShuttleInstance.transform.position;
            o_ShuttleInstance.transform.rotation = Quaternion.LookRotation(Vector3.forward, targetOffset);

            // Wait a random amount of time before respawning
            yield return new WaitForSeconds(Random.Range(f_SpawnTimeLowerRange, f_SpawnTimeUpperRange));
        }
    }
}
