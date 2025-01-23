using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task2 : MonoBehaviour
{
    public float coverPrice = 0;
    public int booksSold = 0;
    private float profit;
    private float cost;

    
    // Start is called before the first frame update
    void Start()
    {
        MyEquation(coverPrice, booksSold);

        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void MyEquation(float myCoverPrice, int myBooksSold)
    {
        cost = (float)((myCoverPrice * myBooksSold * 0.6) + (3 + (0.75 * (myBooksSold - 1))));  // Wholescale cost equation 

        profit = (float)(myBooksSold * myCoverPrice) - cost; //Profit equation 

        Debug.Log("Profit = " + profit + " Cost = " + cost); // System output
      
    }
}
