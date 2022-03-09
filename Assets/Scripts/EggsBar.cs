using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Required when Using UI elements.

public class EggsBar : MonoBehaviour
{
    public Slider eggsBar;
    int eggs;
    void Start()
    {
        eggs = 0;
    }
    void Update()
    {
        if(eggs==eggsBar.maxValue){
            Application.Quit();    
        }
    }
    public void addEggs(int n){
        eggs += n;
    }
    public void addEgg(){
        addEggs(1);
    }

}
