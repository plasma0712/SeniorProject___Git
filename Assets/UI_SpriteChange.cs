using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_SpriteChange : Singleton<UI_SpriteChange>
{
    #region 성향 UI 이미지 바꾸는 영역
    public Sprite[] Tendency;
    public GameObject TendencyTopUI;

    public void Start()
    {
        //TendencyChangeUI();
    }
    public void TendencyChangeUI()
    {
        TendencyTopUI.GetComponent<Image>().sprite = Tendency[(int)TendencyUIData.Instance.fTendency];
    }
    #endregion

    public IEnumerator MenuCoroutine()
    {
        yield return new WaitForSeconds(0.02f);
        TendencyChangeUI();
    }

    public void CoroutineStart()
    {
        StartCoroutine("MenuCoroutine");
    }
}
