using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public bird_script mybird;
    public GameObject Borular;
    public float topheight;
    public float lowheight;
    public float time;
    void Start()
    {
        StartCoroutine(SpawnObject(time));
    }
    public IEnumerator SpawnObject(float time)
    {
        while (!mybird.isDead)
        {
            Instantiate(Borular,new Vector3(3,Random.Range(lowheight, topheight),0),Quaternion.identity);
            yield return new WaitForSeconds(time);
        }
    }
}
