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
        //���������
        //foreach (var item in EnemyData.EnemyDataEntities)
        //{
        //    Debug.Log(item.Id + " " + item.Name + " " + item.Health + " " + item.Exp+ " " + item.Attack+ " "+ item.���Ĳ���);
        //}
        {
            var item = EnemyData.EnemyDataEntityDic[1];
            Debug.Log(item.Id + " " + item.Name + " " + item.Health + " " + 
            item.Exp + " " + item.Attack + " " + item.���Ĳ���);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
