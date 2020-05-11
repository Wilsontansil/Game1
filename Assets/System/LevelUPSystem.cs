using Unity.Entities;
using UnityEngine;
using Unity.Transforms;

public class LevelUPSystem : SystemBase
{
    protected override void OnUpdate()
    {

        Entities.ForEach((ref PlayerLevelComponentData PLC,ref Translation trans) =>
        {
            bool input = Input.GetKeyDown(KeyCode.Space);

            if (input)
            {
                PLC.playerLevel += 1;
                trans.Value += new Unity.Mathematics.float3(Random.Range(-5, 5), Random.Range(-5, 5), 0f);
            }

        }).Run();
    }
}
