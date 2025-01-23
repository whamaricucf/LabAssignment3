using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab3Task3 : MonoBehaviour
{

    public int paidAmount;

    private int hundred;
    private int fifty;
    private int twenty;
    private int ten;
    private int five;
    private int one;
    private int[] values = new int[] { 100, 50, 20, 10, 5, 1 };
    private int n;
    private int total;

    private bool hundredCheck;
    private bool fiftyCheck;
    private bool twentyCheck;
    private bool tenCheck;
    private bool fiveCheck;
    private bool oneCheck;

    private string hundredOutput;
    private string fiftyOutput;
    private string twentyOutput;
    private string tenOutput;
    private string fiveOutput;
    private string oneOutput;

    // Start is called before the first frame update
    void Start()
    {
        n = 0;
        total = paidAmount;
        AmountCalc();
        Output();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AmountCalc()
    {
        //This function takes the inputted amount and subtracts by the value of each bill every loop which takes from an array that holds the value of each bill until the inputted amount reaches 0
        if (paidAmount >= values[n])
        {
            paidAmount = paidAmount - values[n];
            DollarBills();
            AmountCalc();
        } else if (n < 5)
        {
            n++;
            AmountCalc();
        }
    }

    void DollarBills()
    {
        //This function incrementally adds the amount of each bill used AND checks IF a type of bill is used
        if (n == 0)
        {
            hundred++;
            hundredCheck = true;
        } else if (n == 1)
        {
            fifty++;
            fiftyCheck = true;
        } else if (n == 2)
        {
            twenty++;
            twentyCheck = true;
        } else if (n == 3)
        {
            ten++;
            tenCheck = true;
        } else if (n == 4)
        {
            five++;
            fiveCheck = true;
        } else if (n == 5)
        {
            one++;
            oneCheck = true;
        }
    }

    void Output()
    {
        //This function outputs the total and the number of each type of bill IF they are used
        if (hundredCheck == true)
        {
            hundredOutput = (" $100: " + hundred);
        } else
        {
            hundredOutput = "";
        } if (fiftyCheck == true)
        {
            fiftyOutput = (" $50: " + fifty);
        } else
        {
            fiftyOutput = "";
        } if (twentyCheck == true)
        {
            twentyOutput = (" $20: " + twenty);
        } else
        {
            twentyOutput = "";
        } if (tenCheck == true)
        {
            tenOutput = (" $10: " + ten);
        } else
        {
            tenOutput = "";
        } if (fiveCheck == true)
        {
            fiveOutput = (" $5: " + five);
        } else
        {
            fiveOutput = "";
        } if (oneCheck == true)
        {
            oneOutput = (" $1: " + one);
        } else
        {
            oneOutput = "";
        }
        Debug.Log("Total: $" + total + hundredOutput + fiftyOutput + twentyOutput + tenOutput + fiveOutput + oneOutput);
    }
}
