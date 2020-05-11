using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Transforms;
using Unity.Collections;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EntityManager entity = World.DefaultGameObjectInjectionWorld.EntityManager;
        EntityArchetype entityarchectype = entity.CreateArchetype(
            typeof(EnemyData),
            typeof(PlayerLevelComponentData),
            typeof(LocalToWorld)
            );
        NativeArray<Entity> entityarray = new NativeArray<Entity>(1, Allocator.Temp);
        entity.CreateEntity(entityarchectype, entityarray);

        for (int i  = 0; i  < entityarray.Length; i ++)
        {
            Entity entitys = entityarray[i];

            entity.SetComponentData(entitys, new EnemyData { level = 8 });
            entity.SetComponentData(entitys, new PlayerLevelComponentData { playerLevel = 9 });
        }

        entityarray.Dispose();
    }

}
