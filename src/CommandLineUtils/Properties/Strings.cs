﻿// Copyright (c) Nate McMaster.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Reflection;

namespace McMaster.Extensions.CommandLineUtils
{
    internal static class Strings
    {
        public const string DefaultHelpTemplate = "-?|-h|--help";
        public const string DefaultHelpOptionDescription = "Show help information";

        public const string NoValueTypesMustBeBoolean
            = "Cannot specify CommandOptionType.NoValue unless the type is boolean.";

        public static string CannotDetermineOptionType(PropertyInfo member)
        {
            return $"Could not automatically determine the {nameof(CommandOptionType)} for type {member.PropertyType.FullName}. " +
                    $"Set the {nameof(OptionAttribute.OptionType)} on the {nameof(OptionAttribute)} declaration for {member.DeclaringType.FullName}.{member.Name}.";
        }

        public static string OptionNameIsAmbiguous(string optionName, PropertyInfo first, PropertyInfo second)
        {
            return $"Ambiguous option name. Both {first.DeclaringType.FullName}.{first.Name} and {second.DeclaringType.FullName}.{second.Name} produce a CommandOption with the name '{optionName}'";
        }

        public static string BothOptionAndArgumentAttributesCannotBeSpecified(PropertyInfo prop)
        {
            return $"Cannot specify both {nameof(OptionAttribute)} and {nameof(ArgumentAttribute)} on a property {prop.DeclaringType.Name}.{prop.Name}.";
        }
        
        public static string BothOptionAndHelpOptionAttributesCannotBeSpecified(PropertyInfo prop)
        {
            return $"Cannot specify both {nameof(OptionAttribute)} and {nameof(HelpOptionAttribute)} on a property {prop.DeclaringType.Name}.{prop.Name}.";
        }

        public static string DuplicateArgumentPosition(int order, PropertyInfo first, PropertyInfo second)
        {
            return $"Duplicate value for argument order. Both {first.DeclaringType.FullName}.{first.Name} and {second.DeclaringType.FullName}.{second.Name} have set Order = {order}";
        }

        public static string OnlyLastArgumentCanAllowMultipleValues(string lastArgName)
        {
            return $"The last argument '{lastArgName}' accepts multiple values. No more argument can be added.";
        }

        public static string CannotDetermineParserType(PropertyInfo prop)
        {
            return $"Could not automatically determine how to convert string values into {prop.PropertyType.FullName}.";
        }

        public static string MultipleValuesArgumentShouldBeCollection
            = "ArgumentAttribute.MultipleValues should be true if the property type is an array or collection.";

        public const string HelpOptionOnTypeAndProperty
            = "Multiple HelpOptions found. HelpOptionAttribute should only be used one per type, either on one property or on the type.";

        public const string MultipleHelpOptionPropertiesFound
            = "Multiple HelpOptions found. HelpOptionAttribute should only be used on one property per type.";
    }
}