using SolastaModApi.Extensions;
using SolastaModApi;

namespace SolastaDivineHumans
{
    public class DivineHumanFeatureDefinitionCastSpellBuilder : BaseDefinitionBuilder<FeatureDefinitionCastSpell>
    {
        // Other constructors not required

        // Clone ctor
        public DivineHumanFeatureDefinitionCastSpellBuilder(FeatureDefinitionCastSpell original, SpellListDefinition spellList, string name, string guid) : base(original, name, guid)
        {
            var presentation = new GuiPresentation
            {
                Title = "Divine Human Cantrip",
                Description = "Choose one Cleric Cantrip, using Wisdom as the spellcasting ability."
            };

            // Configure
            Definition
                .SetStaticDCValue(10)
                .SetStaticToHitValue(4)
                .SetSpellcastingAbility("Wisdom")
                .SetSpellKnowledge(RuleDefinitions.SpellKnowledge.Selection)
                .SetSpellCastingLevel(-1)
                .SetGuiPresentation(presentation)
                .SetSpellListDefinition(spellList);
        }
    }
}