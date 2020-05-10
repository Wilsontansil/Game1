using Unity.Entities;
using UnityEngine;

public class LevelUPSystem : SystemBase
{
    protected override void OnUpdate()
    {
        Entities.ForEach((ref PlayerLevelComponentData PLC) =>
        {
                PLC.playerLevel += 1;
        }).ScheduleParallel();
    }
}
