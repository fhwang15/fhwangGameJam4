using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SummonThings : MonoBehaviour
{
    // Start is called before the first frame update
    public List<Transform> Thin = new List<Transform>();

    public LittleThings Things;

    public int spawncount;
    public float spawnBtwn;

    // Start is called before the first frame update
    void Start()
    {
        List<Transform> usedFallPosition = new List<Transform>();


        for (int i = 0; i < spawncount; i++)
        {
            int randomIndex = Random.Range(0, Thin.Count);
            Transform fallPos = Thin[randomIndex];

            while (usedFallPosition.Contains(fallPos))
            {
                randomIndex = Random.Range(0, Thin.Count);
                fallPos = Thin[randomIndex];
            }


            LittleThings newthings = Instantiate(Things);
            newthings.moveHandle.position = fallPos.position;

            usedFallPosition.Add(fallPos);

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
