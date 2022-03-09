using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;


public class SpawnEggs : MonoBehaviour
{
    public GameObject egg;
    public List<GameObject> _clone;
    public int eggs;
    public Slider eggsBar;

    int contador;
    float spawnX,spawnY;
    Vector2 spawnPosition;

    void Start()
    {
        //Debug.Log("Screen Height : " + Screen.height);
        //Debug.Log("Screen Width : " + Screen.width);
        _clone = new List<GameObject>();
        eggs = 0;
        eggsBar.maxValue = 100;
        eggsBar.value = 0;
    }
    
    public void Spawn(){
        
        /*
        spawnY = Random.Range(Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).y, Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height)).y);
        spawnX = Random.Range(Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x, Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x);
        spawnPosition = new Vector2(spawnX, spawnY);
        */
        spawnY = Random.value*0.9f+0.02f;
        spawnX = Random.value*0.85f+0.02f;
        if(spawnX>0.3 && spawnX<0.7){
            spawnY = spawnY*0.8f+0.2f;
        }
        
        
        spawnPosition = Camera.main.ViewportToWorldPoint(new Vector2(spawnX, spawnY));
        
        //Debug.Log("X :"+ spawnX +"Y :"+ spawnY );
        
        _clone.Add(Instantiate(egg, spawnPosition, Quaternion.identity));

    }
    void Update(){
        contador=_clone.Count;
        if(contador >= 10){
            foreach (GameObject n in _clone){
                Destroy(n);
            }
            _clone.Clear();
            eggs+=contador;
            eggsBar.value = eggs;
        }
        
        if(eggs>=eggsBar.maxValue){
            Application.Quit();    
        }
    }
}