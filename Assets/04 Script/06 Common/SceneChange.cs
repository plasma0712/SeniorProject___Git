using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : Singleton <SceneChange>
{
    public void LobbyMapSceneChange()
    {
        SceneManager.LoadScene("MapSetting");
    }

    public void MapLobbySceneChange()
    {
        SceneManager.LoadScene("Lobby");
    }

    public void IntroLobbySceneChange()
    {
        SceneManager.LoadScene("Lobby");
    }

    public void LobbyStartGameSceneChange()
    {
        SceneManager.LoadScene("GameStart");
    }

    /////////////////////////////////////////////////////////////////////////////
    public void IntroMapSettingTutorial()
    {
        XMLCharInfoCharacteristicPoint.Instance.NewGameCreateXml();
        XMLCharInfoTendency.Instance.NewGameCreateXml();
        XMLLobbyTopUI.Instance.NewGameCreateXml();
        XMLClearScene.Instance.NewGameCreateXml();
        XMLCharInfoCharacteristic.Instance.CreateXml();
        XMLMonsterSummon.Instance.Create();
        XMLMonsterListUnLock.Instance.Create();
        XMLCharInfoTendency.Instance.NewGameCreateXml();
        XMLMonsterListUnLock.Instance.AddXmlNode(XMLMonsterListUnLock.Instance.MonsterListUnLockLegth().ToString(), 1.ToString());// 몬스터 락


        //넘어가기전에 XML을 Create해야하기 때문에(NEW 게임이니깐) 
        SceneManager.LoadScene("MapSettingTutorial");
    }

    public void MapSettingGameStartTutorial()
    {
        SceneManager.LoadScene("GameStartTutorial");
    }

    public void GameStartScene()
    {
        if(ClearStageNumber.Instance.StageNumber>=4)
        {
            ///summary///
            ///엔딩 씬으로 넘어가야함.
            ///Tendency가 
            ///선 일 경우 
            ///악 일 경우
            ///중립 일 경우
            ///
            ///기본적으로 이벤트 씬은 3가지
            ///히든 이벤트도 넣어 볼 생각 (하트가 5개 이상일 경우)
            ///
            /// 
            ///summary///
        }
        else
        SceneManager.LoadScene("GameStart");

    }



}
