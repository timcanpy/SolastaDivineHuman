using System.Collections.Generic;
using SolastaModApi.Infrastructure;
using static FeatureDefinitionCastSpell;

namespace DivineHumans.Extensions
{
    public static class SpellCastExtensions
    {
        public static FeatureDefinitionCastSpell NewFeatureDefinitionCastSpell(FeatureDefinitionCastSpell modifiedCast, FeatureDefinitionCastSpell oldSpellCast)
        {
            modifiedCast = SpellCastExtensions.SetSpellCastingOrigin(modifiedCast, oldSpellCast.SpellCastingOrigin);
            modifiedCast = SpellCastExtensions.SetSpellCastingAbility(modifiedCast, Enumerators.SpellCastingAbility.Wisdom);
            modifiedCast = SpellCastExtensions.SetStaticDCValue(modifiedCast, 10);
            modifiedCast = SpellCastExtensions.SetStaticToHit(modifiedCast, 4);
            modifiedCast = SpellCastExtensions.SetSpellRestrictedSchool(modifiedCast, oldSpellCast.RestrictedSchools);
            modifiedCast = SpellCastExtensions.SetSpellKnowledge(modifiedCast, RuleDefinitions.SpellKnowledge.Selection);
            modifiedCast = SpellCastExtensions.SetSpellCastingLevel(modifiedCast, -1);
            modifiedCast = SpellCastExtensions.SetKnownCantripsValue(modifiedCast, oldSpellCast.KnownCantrips);
            modifiedCast = SpellCastExtensions.SetKnownSpellsValue(modifiedCast, oldSpellCast.KnownSpells);
            modifiedCast = SpellCastExtensions.SetScribedSpellsValue(modifiedCast, oldSpellCast.ScribedSpells);
            modifiedCast = SpellCastExtensions.SetSlotsPerLevelValue(modifiedCast, oldSpellCast.SlotsPerLevels);
            modifiedCast = SpellCastExtensions.Setguid(modifiedCast, oldSpellCast.GUID);
            return modifiedCast;
        }
        public static T SetSpellCastingOrigin<T>(this T entity, CastingOrigin value)
  where T : FeatureDefinitionCastSpell
        {
            entity.SetField("spellCastingOrigin", value);
            return entity;
        }
        public static T SetSpellCastingAbility<T>(this T entity, Enumerators.SpellCastingAbility value)
   where T : FeatureDefinitionCastSpell
        {
            entity.SetField("spellcastingAbility", value.ToString());
            return entity;
        }
        public static T SetStaticDCValue<T>(this T entity, int value)
where T : FeatureDefinitionCastSpell
        {
            entity.SetField("staticDCValue", value);
            return entity;
        }
        public static T SetStaticToHit<T>(this T entity, int value)
where T : FeatureDefinitionCastSpell
        {
            entity.SetField("staticToHitValue", value);
            return entity;
        }
        public static T SetSpellListDefinition<T>(this T entity, SpellListDefinition value)
where T : FeatureDefinitionCastSpell
        {
            entity.SetField("spellListDefinition", value);
            return entity;
        }
        public static T SetSpellRestrictedSchool<T>(this T entity, List<string> value)
where T : FeatureDefinitionCastSpell
        {
            entity.SetField("restrictedSchools", value);
            return entity;
        }
        public static T SetSpellKnowledge<T>(this T entity, RuleDefinitions.SpellKnowledge value)
where T : FeatureDefinitionCastSpell
        {
            entity.SetField("spellKnowledge", value);
            return entity;
        }
        public static T SetSpellCastingLevel<T>(this T entity, int value)
where T : FeatureDefinitionCastSpell
        {
            entity.SetField("spellCastingLevel", value);
            return entity;
        }

        public static T SetKnownCantripsValue<T>(this T entity, List<int> value)
     where T : FeatureDefinitionCastSpell
        {
            entity.SetField("knownCantrips", value);
            return entity;
        }

        public static T SetKnownSpellsValue<T>(this T entity, List<int> value)
     where T : FeatureDefinitionCastSpell
        {
            entity.SetField("knownSpells", value);
            return entity;
        }
        public static T SetScribedSpellsValue<T>(this T entity, List<int> value)
   where T : FeatureDefinitionCastSpell
        {
            entity.SetField("scribedSpells", value);
            return entity;
        }

        public static T SetSlotsPerLevelValue<T>(this T entity, List<SlotsByLevelDuplet> value)
  where T : FeatureDefinitionCastSpell
        {
            entity.SetField("slotsPerLevels", value);
            return entity;
        }
        public static T SetGUIPresentation<T>(this T entity, GuiPresentation value)
   where T : FeatureDefinitionCastSpell
        {
            entity.SetField("guiPresentation", value);
            return entity;
        }

        public static T Setguid<T>(this T entity, string value)
where T : FeatureDefinitionCastSpell
        {
            entity.SetField("guid", value);
            return entity;
        }
    }
}
