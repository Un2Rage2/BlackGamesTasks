
using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class RndGenerateBlock : MonoBehaviour
{
    public GameObject[] coldObj;
    private int rnd;
    private void Start()
    {
        var randomBlock = Random.Range(3, 10);
        for (int i = 0; i < randomBlock; i++)
        {
            rnd = Random.Range(0, 2);
            randowSpawn();
        }
    }
    private void randowSpawn()
    {
        Instantiate(coldObj[rnd], transform.position, Quaternion.identity);
    }
}
