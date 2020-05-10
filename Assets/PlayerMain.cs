using Unity.Entities;
using UnityEngine;

public class PlayerMain : MonoBehaviour
{
    private void Start()
    {
        EntityManager entitymanager = World.DefaultGameObjectInjectionWorld.EntityManager;
        EntityArchetype entityArchetype = entitymanager.CreateArchetype
        (
            typeof(PlayerLevelComponentData)
        );

        Entity entity = entitymanager.CreateEntity(entityArchetype);

        entitymanager.SetComponentData(entity, new PlayerLevelComponentData { playerLevel = 10 });


    }

}
