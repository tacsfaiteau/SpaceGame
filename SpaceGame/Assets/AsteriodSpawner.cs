using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteriodSpawner : MonoBehaviour
{
    public GameObject asteriodPrefab;
    public Vector3[] spawnPos;
    public float spawnInterval = 1;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            int e = Random.Range(0, 3);
            List<GameObject> wave = new List<GameObject>();
            for (int i = 0; i < spawnPos.Length; i++)
            {
                GameObject asteriod = Instantiate<GameObject>(asteriodPrefab, spawnPos[i], Quaternion.identity);
                asteriod.name = "Asteriod";
                wave.Add(asteriod);
            }
            wave[e].GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0);
            wave[e].name = "Points";

            timer = 0;
            spawnInterval = Random.Range(0.8f, 1.2f);
        }
    }
}