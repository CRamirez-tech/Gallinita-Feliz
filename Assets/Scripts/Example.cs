using UnityEngine;

public class Example : MonoBehaviour
{
    public GameObject banana;
    
    void Start()
    {
        //Debug.Log("RESOLUTION : "+Screen.currentResolution);
        Debug.Log("Screen Height : " + Screen.height);
        Debug.Log("Screen Width : " + Screen.width);
        for (int i = 0; i < 10; i++)
        {
            float spawnY = Random.Range(Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).y, Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height)).y);
            float spawnX = Random.Range(Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x, Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x);
 
            Vector2 spawnPosition = new Vector2(spawnX, spawnY);
            Instantiate(banana, spawnPosition, Quaternion.identity);
        }
    }
}