using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Points : MonoBehaviour
{
    public GameObject display;
    private TextMeshProUGUI textDisplay; 
    private int points = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (display != null)
            textDisplay = display.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void UpdatePoints()
    {
        var text = $"{points} point";
        if (points != 1)
            text += "s";
        textDisplay.text = text;
    }

    public void Score(int points = 1)
    {
        this.points += points;
        UpdatePoints();
    }

    public int GetScore()
    {
        return points;
    }
}
