using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public int curLevel = 0;
    public GameObject[] levels;
    private GameObject curLevelGO;
   //public Text levelUITxt;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LoadNextLevel()
    {
        if (curLevelGO != null)
        {
            Destroy(curLevelGO);
        }
        if (curLevel < levels.Length)
        {

            curLevelGO = Instantiate(levels[curLevel], levels[curLevel].transform.position, levels[curLevel].transform.rotation) as GameObject;
            curLevel++;
        }
        else
        {
            ResetLevels();
        }
        SetLevelUI();
    }



    void ResetLevels()
    {
        curLevel = 0;
        LoadNextLevel();
    }



    //public void SetLevelUI()
    //{
    //    levelUITxt.text = "Level " + (curLevel);

    //}
}
