using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ScoreScript : MonoBehaviour
{
    TextMeshProUGUI score;
    public Fixitfelix script;

    
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<TextMeshProUGUI> ();
    }

    // Update is called once per frame
    void Update()
    {
        int collectCount = script.collectCount;
        string text = collectCount.ToString("F0");
        score.text = text;
        
    }
}
