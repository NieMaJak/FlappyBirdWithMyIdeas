using UnityEngine;
using System.Collections;

public class SpawnerScript : MonoBehaviour
{

    private GameObject SpawnObjectPipes;
    private GameObject SpawnObjectCoin;
    public GameObject[] SpawnObjects;

    public float timeMin = 0.7f;
    public float timeMax = 2f;

    void Start()
    {
        SpawnObjectPipes = SpawnObjects[0];
        SpawnObjectCoin = SpawnObjects[1];
        Spawn();
    }

    void Spawn()
    {
        if (GameStateManager.GameState == GameState.Playing)
        {
            //randomowa pozycja rur
            float y = Random.Range(-0.5f, 1f);
            float y1 = Random.Range(y-0.5f,y-1.5f);
            GameObject go = Instantiate(SpawnObjectPipes, this.transform.position + new Vector3(0, y, 0), Quaternion.identity) as GameObject;
            GameObject coin = Instantiate(SpawnObjectCoin, this.transform.position + new Vector3(1.5f, y1, 0), Quaternion.identity) as GameObject;
        }
        Invoke("Spawn", Random.Range(timeMin, timeMax));
    }

    
}
