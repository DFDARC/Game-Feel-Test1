using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField]
    GameObject rocket1;
    [SerializeField]
    GameObject rocket2;
    [SerializeField]
    GameObject rocket3;

    public GameController gamC;
    // Start is called before the first frame update
    void Start()
    {

        ObjectPooling.PreLoad(rocket1, 6);
        ObjectPooling.PreLoad(rocket2, 6);
        ObjectPooling.PreLoad(rocket3, 6);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnButton() 
    {
        if (gamC.contCurrentRocket == 1) 
        {
            Vector3 vector = SpawnPosition();
            GameObject c = ObjectPooling.GetObject(rocket1);
            c.transform.position = vector;
            StartCoroutine(DeSpawn(rocket1, c, 2.0f));

        }
    }
    public void SpawnButton2() 
    {
        if (gamC.contCurrentRocket == 2) 
        {
            Vector3 vector2 = SpawnPosition2();
            GameObject c = ObjectPooling.GetObject(rocket2);
            c.transform.position = vector2;
            StartCoroutine(DeSpawn(rocket1, c, 2.0f));
        }
    }
    public void SpawnButton3() 
    {
        if (gamC.contCurrentRocket == 3)
        {
            Vector3 vector3 = SpawnPosition3();
            GameObject c = ObjectPooling.GetObject(rocket3);
            c.transform.position = vector3;
            StartCoroutine(DeSpawn(rocket1, c, 2.0f));
        }
    }

    Vector3 SpawnPosition()
    {
        float x = -2.5761f;
        float y = 1.62f;
        float z = 18.572f;
        Vector3 vector = new Vector3(x, y, z);
        return vector;
    }
    Vector3 SpawnPosition2() 
    {
        float x = -0.277f;
        float y = 0.87f;
        float z = 1.75f;
        Vector3 vector2 = new Vector3(x, y, z);
        return vector2;
    }
    Vector3 SpawnPosition3() 
    {

        float x = -0.04851091f;
        float y = 2.618f;
        float z = 18.7f;
        Vector3 vector3= new Vector3(x, y, z);
        return vector3;
    }
    IEnumerator DeSpawn(GameObject primitive, GameObject go, float time)
    {
        yield return new WaitForSeconds(time);
        ObjectPooling.RecicleObject(primitive, go);
    }
}
