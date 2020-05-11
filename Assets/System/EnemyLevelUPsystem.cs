using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

public class EnemyLevelUPsystem : SystemBase
{
    protected override void OnUpdate()
    {
        Entities.ForEach((ref EnemyData enemy,ref PlayerLevelComponentData PLC) => {
            bool input = Input.GetKeyDown(KeyCode.Space);

            if (input)
            {
                enemy.level += 1;
                PLC.playerLevel += 1;

            }

        }).Run();
    }
}
