using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MenualImageChange : Singleton<MenualImageChange>
{
    #region 특성 메뉴얼 이미지 변경하는 영역
    public Sprite[] Characteristic;
    public GameObject CharacteristicUI;


    public void CharacteristicUIChange(int _Number)
    {
        CharacteristicUI.GetComponent<Image>().sprite = Characteristic[_Number];
    }
    #endregion
}
