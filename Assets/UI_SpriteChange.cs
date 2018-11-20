using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_SpriteChange : Singleton<UI_SpriteChange>
{
    public Sprite[] Tendency;
    public GameObject TendencyTopUI;
    
    public void TendencyChangeUI()
    {
        //.Tendency[(int)TendencyUIData.Instance.fTendency];
        TendencyTopUI.GetComponent<Image>().sprite = Tendency[(int)TendencyUIData.Instance.fTendency];
    }

}
