﻿using SteveCadwallader.CodeMaid.Model.CodeItems;
using SteveCadwallader.CodeMaid.Properties;
using System.Collections.Generic;

namespace SteveCadwallader.CodeMaid.Helpers
{
    /// <summary>
    /// A helper class that simplifies access to <see cref="MemberTypeSetting"/> instances.
    /// </summary>
    public static class MemberTypeSettingHelper
    {
        #region Fields

        private static readonly CachedSetting<MemberTypeSetting> CachedClassSettings;
        private static readonly CachedSetting<MemberTypeSetting> CachedConstructorSettings;
        private static readonly CachedSetting<MemberTypeSetting> CachedDelegateSettings;
        private static readonly CachedSetting<MemberTypeSetting> CachedDestructorSettings;
        private static readonly CachedSetting<MemberTypeSetting> CachedEnumSettings;
        private static readonly CachedSetting<MemberTypeSetting> CachedEventSettings;
        private static readonly CachedSetting<MemberTypeSetting> CachedFieldSettings;
        private static readonly CachedSetting<MemberTypeSetting> CachedIndexerSettings;
        private static readonly CachedSetting<MemberTypeSetting> CachedInterfaceSettings;
        private static readonly CachedSetting<MemberTypeSetting> CachedMethodSettings;
        private static readonly CachedSetting<MemberTypeSetting> CachedPropertySettings;
        private static readonly CachedSetting<MemberTypeSetting> CachedStructSettings;
        private static readonly CachedSetting<MemberTypeSetting> CachedDisposeSettings;
        private static readonly CachedSetting<MemberTypeSetting> CachedOperatorSettings;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// The static initializer for the <see cref="MemberTypeSettingHelper"/> class.
        /// </summary>
        static MemberTypeSettingHelper()
        {
            CachedClassSettings = new CachedSetting<MemberTypeSetting>(() => Settings.Default.Reorganizing_MemberTypeClasses, x => (MemberTypeSetting)x);
            CachedConstructorSettings = new CachedSetting<MemberTypeSetting>(() => Settings.Default.Reorganizing_MemberTypeConstructors, x => (MemberTypeSetting)x);
            CachedDelegateSettings = new CachedSetting<MemberTypeSetting>(() => Settings.Default.Reorganizing_MemberTypeDelegates, x => (MemberTypeSetting)x);
            CachedDestructorSettings = new CachedSetting<MemberTypeSetting>(() => Settings.Default.Reorganizing_MemberTypeDestructors, x => (MemberTypeSetting)x);
            CachedEnumSettings = new CachedSetting<MemberTypeSetting>(() => Settings.Default.Reorganizing_MemberTypeEnums, x => (MemberTypeSetting)x);
            CachedEventSettings = new CachedSetting<MemberTypeSetting>(() => Settings.Default.Reorganizing_MemberTypeEvents, x => (MemberTypeSetting)x);
            CachedFieldSettings = new CachedSetting<MemberTypeSetting>(() => Settings.Default.Reorganizing_MemberTypeFields, x => (MemberTypeSetting)x);
            CachedIndexerSettings = new CachedSetting<MemberTypeSetting>(() => Settings.Default.Reorganizing_MemberTypeIndexers, x => (MemberTypeSetting)x);
            CachedInterfaceSettings = new CachedSetting<MemberTypeSetting>(() => Settings.Default.Reorganizing_MemberTypeInterfaces, x => (MemberTypeSetting)x);
            CachedMethodSettings = new CachedSetting<MemberTypeSetting>(() => Settings.Default.Reorganizing_MemberTypeMethods, x => (MemberTypeSetting)x);
            CachedPropertySettings = new CachedSetting<MemberTypeSetting>(() => Settings.Default.Reorganizing_MemberTypeProperties, x => (MemberTypeSetting)x);
            CachedStructSettings = new CachedSetting<MemberTypeSetting>(() => Settings.Default.Reorganizing_MemberTypeStructs, x => (MemberTypeSetting)x);
            CachedDisposeSettings = new CachedSetting<MemberTypeSetting>(() => Settings.Default.Reorganizing_MemberTypeDispose, x => (MemberTypeSetting)x);
            CachedOperatorSettings = new CachedSetting<MemberTypeSetting>(() => Settings.Default.Reorganizing_MemberTypeOperators, x => (MemberTypeSetting)x);
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets an enumerable set of all of the settings.
        /// </summary>
        public static IEnumerable<MemberTypeSetting> AllSettings => new[]
        {
            ClassSettings, ConstructorSettings, DelegateSettings, DestructorSettings,
            EnumSettings, EventSettings, FieldSettings, IndexerSettings, InterfaceSettings,
            MethodSettings, PropertySettings, StructSettings, DisposeSettings, OperatorSettings
        };

        /// <summary>
        /// Gets the settings associated with the <see cref="KindCodeItem.Class"/> type.
        /// </summary>
        public static MemberTypeSetting ClassSettings => CachedClassSettings.Value;

        /// <summary>
        /// Gets the settings associated with the <see cref="KindCodeItem.Constructor"/> type.
        /// </summary>
        public static MemberTypeSetting ConstructorSettings => CachedConstructorSettings.Value;

        /// <summary>
        /// Gets the settings associated with the <see cref="KindCodeItem.Delegate"/> type.
        /// </summary>
        public static MemberTypeSetting DelegateSettings => CachedDelegateSettings.Value;

        /// <summary>
        /// Gets the settings associated with the <see cref="KindCodeItem.Destructor"/> type.
        /// </summary>
        public static MemberTypeSetting DestructorSettings => CachedDestructorSettings.Value;

        /// <summary>
        /// Gets the settings associated with the <see cref="KindCodeItem.Enum"/> type.
        /// </summary>
        public static MemberTypeSetting EnumSettings => CachedEnumSettings.Value;

        /// <summary>
        /// Gets the settings associated with the <see cref="KindCodeItem.Event"/> type.
        /// </summary>
        public static MemberTypeSetting EventSettings => CachedEventSettings.Value;

        /// <summary>
        /// Gets the settings associated with the <see cref="KindCodeItem.Field"/> type.
        /// </summary>
        public static MemberTypeSetting FieldSettings => CachedFieldSettings.Value;

        /// <summary>
        /// Gets the settings associated with the <see cref="KindCodeItem.Indexer"/> type.
        /// </summary>
        public static MemberTypeSetting IndexerSettings => CachedIndexerSettings.Value;

        /// <summary>
        /// Gets the settings associated with the <see cref="KindCodeItem.Interface"/> type.
        /// </summary>
        public static MemberTypeSetting InterfaceSettings => CachedInterfaceSettings.Value;

        /// <summary>
        /// Gets the settings associated with the <see cref="KindCodeItem.Method"/> type.
        /// </summary>
        public static MemberTypeSetting MethodSettings => CachedMethodSettings.Value;

        /// <summary>
        /// Gets the settings associated with the <see cref="KindCodeItem.Property"/> type.
        /// </summary>
        public static MemberTypeSetting PropertySettings => CachedPropertySettings.Value;

        /// <summary>
        /// Gets the settings associated with the <see cref="KindCodeItem.Struct"/> type.
        /// </summary>
        public static MemberTypeSetting StructSettings => CachedStructSettings.Value;

        /// <summary>
        /// Gets the settings associated with the <see cref="KindCodeItem.Dispose"/> type.
        /// </summary>
        public static MemberTypeSetting DisposeSettings => CachedDisposeSettings.Value;

        /// <summary>
        /// Gets the settings associated with the <see cref="KindCodeItem.Operator"/> type.
        /// </summary>
        public static MemberTypeSetting OperatorSettings => CachedOperatorSettings.Value;

        #endregion Properties

        #region Methods

        /// <summary>
        /// Looks up the <see cref="MemberTypeSetting"/> associated with the specified kind, otherwise null.
        /// </summary>
        /// <param name="kindCodeItem">The kind of code item.</param>
        /// <returns>The associated <see cref="MemberTypeSetting"/>, otherwise null.</returns>
        public static MemberTypeSetting LookupByKind(KindCodeItem kindCodeItem)
        {
            switch (kindCodeItem)
            {
                case KindCodeItem.Class: return ClassSettings;
                case KindCodeItem.Constructor: return ConstructorSettings;
                case KindCodeItem.Delegate: return DelegateSettings;
                case KindCodeItem.Destructor: return DestructorSettings;
                case KindCodeItem.Enum: return EnumSettings;
                case KindCodeItem.Event: return EventSettings;
                case KindCodeItem.Field: return FieldSettings;
                case KindCodeItem.Indexer: return IndexerSettings;
                case KindCodeItem.Interface: return InterfaceSettings;
                case KindCodeItem.Method: return MethodSettings;
                case KindCodeItem.Property: return PropertySettings;
                case KindCodeItem.Struct: return StructSettings;
                case KindCodeItem.Dispose: return DisposeSettings;
                case KindCodeItem.Operator: return OperatorSettings;
                default: return null;
            }
        }

        #endregion Methods
    }
}