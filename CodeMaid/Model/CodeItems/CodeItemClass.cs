using EnvDTE;
using EnvDTE80;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SteveCadwallader.CodeMaid.Model.CodeItems
{
    /// <summary>
    /// The representation of a code class.
    /// </summary>
    public class CodeItemClass : BaseCodeItemElementParent
    {
        private readonly Lazy<IEnumerable<CodeElement>> _implementedInterfaces;

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeItemClass" /> class.
        /// </summary>
        public CodeItemClass()
        {
            _Access = LazyTryDefault(
                () => CodeClass?.Access ?? vsCMAccess.vsCMAccessPublic);

            _Attributes = LazyTryDefault(
                () => CodeClass?.Attributes);

            _DocComment = LazyTryDefault(
                () => CodeClass?.DocComment);

            _IsStatic = LazyTryDefault(
                () => CodeClass != null && CodeClass.IsShared);

            _Namespace = LazyTryDefault(
                () => CodeClass?.Namespace?.Name);

            _implementedInterfaces = LazyTryDefault(() => CodeClass?.ImplementedInterfaces.Cast<CodeElement>().ToList() ?? Enumerable.Empty<CodeElement>());

            _TypeString = new Lazy<string>(
                () => "class");
        }

        #endregion Constructors

        #region BaseCodeItem Overrides

        /// <summary>
        /// Gets the kind.
        /// </summary>
        public override KindCodeItem Kind => KindCodeItem.Class;

        #endregion BaseCodeItem Overrides

        #region Properties

        /// <summary>
        /// Gets or sets the underlying VSX CodeClass.
        /// </summary>
        public CodeClass2 CodeClass { get; set; }

        /// <summary>
        /// Gets the implemented interfaces of the class.
        /// </summary>
        public IEnumerable<CodeElement> ImplementedInterfaces => _implementedInterfaces.Value;

        #endregion Properties
    }
}