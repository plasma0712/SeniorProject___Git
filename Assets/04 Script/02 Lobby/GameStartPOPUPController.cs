using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStartPOPUPController : Singleton<GameStartPOPUPController>
{
    #region 스테이지 클리어시!!!
    public GameObject ToolTipStageEnd;

    public Text tCurrentStageNumber;
    public Image iEnemyImage;
    public Text tCurrentEnemyNumbering;

    public Sprite[] EnemySprite;

    public void GameStartPOPUP()
    {
        StartCoroutine("GameStartButtonClick");
    }

    IEnumerator GameStartButtonClick() //게임스타트버튼 클릭시 단 한번만 사용 할 예정
    {
        if(ClearStageNumber.Instance.StageNumber==1)
        {
            tCurrentStageNumber.text = ClearStageNumber.Instance.StageNumber.ToString();
            iEnemyImage.sprite = EnemySprite[0];
        }
        else if (ClearStageNumber.Instance.StageNumber == 2)
        {
            tCurrentStageNumber.text = ClearStageNumber.Instance.StageNumber.ToString();
            iEnemyImage.sprite = EnemySprite[1];
        }
        else if (ClearStageNumber.Instance.StageNumber == 3)
        {
            tCurrentStageNumber.text = ClearStageNumber.Instance.StageNumber.ToString();
            iEnemyImage.sprite = EnemySprite[2];
        }
        else
        {
            yield break;
        }
        yield return new WaitForSeconds(0.1f);
    }


    public void StageClearDeathSelect() //죽일 때,
    {
        ClearStageNumber.Instance.ClearStage();
        LobbyTopUIData.Instance.GetGold(500);
        LobbyTopUIData.Instance.GetSoul(500);
        LobbyTopUIData.Instance.GetHeart(1);
        CharacteristicUIData.Instance.GetCharacteristicPoint(10);
    }

    public void StageClearLifeSelect() //살릴 때,
    {
        ClearStageNumber.Instance.ClearStage();
        LobbyTopUIData.Instance.GetGold(200);
        LobbyTopUIData.Instance.GetSoul(200);
        CharacteristicUIData.Instance.GetCharacteristicPoint(5);
    }
    #endregion

    public GameObject ToolTipGameEnd;


}
