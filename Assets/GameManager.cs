using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public EnemyData EnemyData;

    // Start is called before the first frame update
    void Start()
    {
        EnemyData.Init();
        Debug.Log(EnemyData.EnemyDataEntityDic.Count);
        //输出表内容
        //foreach (var item in EnemyData.EnemyDataEntities)
        //{
        //    Debug.Log(item.Id + " " + item.Name + " " + item.Health + " " + item.Exp+ " " + item.Attack+ " "+ item.中文测试);
        //}
        {
            var item = EnemyData.EnemyDataEntityDic[1];
            Debug.Log(item.Id + " " + item.Name + " " + item.Health + " " + 
            item.Exp + " " + item.Attack + " " + item.中文测试);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
