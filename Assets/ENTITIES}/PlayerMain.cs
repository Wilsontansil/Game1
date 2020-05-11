using Unity.Entities;
using UnityEngine;
using Unity.Transforms;
using Unity.Rendering;
using Unity.Collections;
using Unity.Mathematics;
using Unity.Physics;
public class PlayerMain : MonoBehaviour
{
    public Mesh mesh;
    public UnityEngine.Material material;
    private void Start()
    {
        EntityManager entitymanager = World.DefaultGameObjectInjectionWorld.EntityManager;
        NativeArray<Entity> entityarray = new NativeArray<Entity>(20, Allocator.Temp);
        EntityArchetype entityArchetype = entitymanager.CreateArchetype
        (
            typeof(PlayerLevelComponentData),
            typeof(LocalToWorld),
            typeof(RenderMesh),
            typeof(Translation),
            typeof(RenderBounds)
           
        );


        entitymanager.CreateEntity(entityArchetype, entityarray);

        for (int i = 0; i < entityarray.Length; i++)
        {
            Entity entity = entityarray[i];

            entitymanager.SetSharedComponentData(entity, new RenderMesh { mesh = mesh, material = material });
            entitymanager.SetComponentData(entity, new PlayerLevelComponentData { playerLevel = 10 });
            entitymanager.SetComponentData(entity, new Translation {Value = new float3(UnityEngine.Random.Range(-5,5), UnityEngine.Random.Range(-5, 5),0f) });
        }

        entityarray.Dispose();

    }

}
