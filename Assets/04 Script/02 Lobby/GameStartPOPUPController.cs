﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStartPOPUPController : Singleton<GameStartPOPUPController>
{
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


    public void StageClearDeathSelect()
    {
        ClearStageNumber.Instance.ClearStage();
        LobbyTopUIData.Instance.GetGold(500);
        LobbyTopUIData.Instance.GetSoul(500);

    }

    public void StageClearLifeSelect()
    {
        ClearStageNumber.Instance.ClearStage();
        LobbyTopUIData.Instance.GetGold(200);
        LobbyTopUIData.Instance.GetSoul(200);

    }

}
