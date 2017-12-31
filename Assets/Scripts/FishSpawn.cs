using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawn : MonoBehaviour {

    public int numberOfFish;
    public float[] YFix;
    public float jumpSpeed;

    public GameObject fish;

    private Rigidbody2D fishBody;

    private float minZ = -1.6f;
    private float maxZ = 1.6f;

    public float spawnTime;


    void Start () {

        //InvokeRepeating("Spawn", spawnTime, spawnTime );
        StartCoroutine(RandomWait());


    }
	
    IEnumerator RandomWait()
    {
        while (true)
        {
            float YRandom = YFix[Random.Range(0, YFix.Length)];
            float ZRandom = Random.Range(minZ, maxZ);


            GameObject newFish = Instantiate(fish, new Vector2(ZRandom, 0f), Quaternion.identity);
            fishBody = newFish.GetComponent<Rigidbody2D>();
            fishBody.AddForce(new Vector2(0, YRandom), ForceMode2D.Impulse);
            yield return new WaitForSeconds(Random.Range(0.2f, 1.5f));
        }
    }



    void Spawn ()
    {
        float YRandom = YFix[Random.Range(0, YFix.Length)];
        float ZRandom = Random.Range(minZ, maxZ);


        GameObject newFish = Instantiate(fish, new Vector2(ZRandom, 0f), Quaternion.identity);
        fishBody = newFish.GetComponent<Rigidbody2D>();
        fishBody.AddForce(new Vector2(0, YRandom), ForceMode2D.Impulse);

    }
}
