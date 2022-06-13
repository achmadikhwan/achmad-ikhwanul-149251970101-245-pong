using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text ScoreL;
    public Text ScoreR;
    public ScoreManager manager;

    private void Update()
    {
        ScoreL.text = manager.lScore.ToString();
        ScoreR.text = manager.rScore.ToString();
    }

}
