using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charactor_info : Singleton<charactor_info>{

    #region 玩家角色信息
    /*
     * 临时用作角色信息存储
     */
    private int health;     //生命
    private int endurance;  //耐力
    private int attack;   //攻击力
    private float movespeed; //移动速度
    #endregion

    #region 信息封装
       public int Health{
            get { return health; }
            set { health = value; }
          }
    public int Enduance
    {
        get { return endurance; }
        set { endurance = value; }
    }
    public int Attack
    {
        get { return attack; }
        set { attack = value; }
    }
    public float Movespeed
    {
        get { return movespeed; }
        set { movespeed = value; }
    }
    #endregion

    #region 初始化角色信息
    private void setchara()
    {
        Health = 5;
        Enduance = 5;
        Attack = 10;
        movespeed = 6;
    }
    #endregion
    private void Start()
    {
        setchara();
    }
}


