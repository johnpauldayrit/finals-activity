using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Sciprt : MonoBehaviour
{
    public GameObject mpanel;
    public GameObject gpanel;
    public TMP_Text leftT;
    public TMP_Text leftT2;
    public TMP_Text rightT;
    public TMP_Text rightT2;
    public TMP_Text mleft;
    public TMP_Text mleft2;
    public TMP_Text mright;
    public TMP_Text mright2;
    private int left;
    private int right;
    // Start is called before the first frame update
    void Start()
    {
        left = PlayerPrefs.GetInt("left");
        right = PlayerPrefs.GetInt("right");
    }

    // Update is called once per frame
    void Update()
    {
        leftT.text = left.ToString();
        leftT2.text = left.ToString();
        rightT.text = right.ToString();
        rightT2.text = right.ToString();
        mleft.text = left.ToString();
        mleft2.text = left.ToString();
        mright.text = right.ToString();
        mright2.text = right.ToString();
    }

    public void Left()
    {
        left++;
    }

    public void Right()
    {
        right++;
    }

    public void StartB()
    {
        left = 0;
        right = 0;
    }

    public void SubmitB()
    {
        PlayerPrefs.SetInt("left", left);
        PlayerPrefs.SetInt("right", right);
    }
}
