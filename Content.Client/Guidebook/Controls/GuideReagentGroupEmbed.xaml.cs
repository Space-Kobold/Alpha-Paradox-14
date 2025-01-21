using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Content.Client.Guidebook.Richtext;
using Content.Shared._APCore.Chemistry.Registry.Systems;
using Content.Shared.Chemistry.Reagent;
using JetBrains.Annotations;
using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface;
using Robust.Client.UserInterface.Controls;
using Robust.Client.UserInterface.XAML;
using Robust.Shared.Prototypes;

namespace Content.Client.Guidebook.Controls;

/// <summary>
///     Control for embedding a reagent into a guidebook.
/// </summary>
[UsedImplicitly, GenerateTypedNameReferences]
public sealed partial class GuideReagentGroupEmbed : BoxContainer, IDocumentTag
{
    [Dependency] private readonly IPrototypeManager _prototype = default!;
    [Dependency] private readonly EntitySystemManager _systemManager = default!;

    private readonly ChemRegistrySystem _chemRegistry;
    public GuideReagentGroupEmbed()
    {
        RobustXamlLoader.Load(this);
        IoCManager.InjectDependencies(this);
        _chemRegistry = _systemManager.GetEntitySystem<ChemRegistrySystem>();
        MouseFilter = MouseFilterMode.Stop;
    }

    public GuideReagentGroupEmbed(string group) : this()
    {
        var prototypes = _chemRegistry.EnumerateReagentPrototypes()
            .Where(p => p.Group.Equals(group)).OrderBy(p => p.LocalizedName);
        foreach (var reagent in prototypes)
        {
            var embed = new GuideReagentEmbed(reagent);
            GroupContainer.AddChild(embed);
        }
    }

    public bool TryParseTag(Dictionary<string, string> args, [NotNullWhen(true)] out Control? control)
    {
        control = null;
        if (!args.TryGetValue("Group", out var group))
        {
            Logger.Error("Reagent group embed tag is missing group argument");
            return false;
        }

        var prototypes =  _chemRegistry.EnumerateReagentPrototypes()
            .Where(p => p.Group.Equals(group)).OrderBy(p => p.LocalizedName);
        foreach (var reagent in prototypes)
        {
            var embed = new GuideReagentEmbed(reagent);
            GroupContainer.AddChild(embed);
        }

        control = this;
        return true;
    }
}
