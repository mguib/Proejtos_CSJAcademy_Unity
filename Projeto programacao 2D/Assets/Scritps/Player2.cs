using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    private int exp;

    public int Experience
    {
        get
        {
            return exp;
        }

        set
        {
            exp = value;
        }
    }

    public int Life
    {
        get
        {
            return exp / 10;
        }

        set
        {
            exp = value * 10;
        }
    }

    public int Lives { get; set; }
}
