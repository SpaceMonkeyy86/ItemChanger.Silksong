using ItemChanger.Items;
using ItemChanger.Placements;
using ItemChanger.Silksong.Containers;
using ItemChanger.Tags;
using ItemChanger.Tags.Constraints;

namespace ItemChanger.Silksong.Tags;

/// <summary>
/// Item tag which runs a custom action at the end of
/// <see cref="ShinyContainer.ModifyContainerInPlace(UnityEngine.GameObject, ItemChanger.Containers.ContainerInfo)"/>,
/// if the parent item is assigned to be given from the shiny.
/// </summary>
[ItemTag]
public abstract class ShinyModifierTag : Tag
{
    public abstract void ModifyShinyContainer(Placement placement, Item item, GameObject shiny);
}
