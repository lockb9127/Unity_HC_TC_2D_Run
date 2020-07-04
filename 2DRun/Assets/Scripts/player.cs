using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    //單行註解
    /*多行註解
     * 
     * 
     * */

    #region
    

    [Header("角色")]
    public int blood = 99;
    [Range(10,49.9f)]
    public float jump = 49.9f;
    public int bulict = 10;
    [Range(10, 29.9f)]
    public float speed = 29.9f;
    public AudioClip jumpsound;
    public AudioClip shootsound;
    public bool dear;


    #endregion
    #region
    private void Jump()
    {
        print("跳躍");
    }
    #endregion

    #region 事件區域
    //開始 start
    //播放遊戲時執行一次
    //初始化:
    #region
    private void slide()
    {
        print("滑行");
    }
    #endregion
    private void Start()
    {
        //呼叫跳躍方法
        Jump();
    }
    //更新Update
    //播放遊戲一秒執行約60次-60FPS
    //移動，監聽玩家鍵盤，滑鼠與觸控
    private void Update()
    {
        slide();
    }
    #endregion
}




