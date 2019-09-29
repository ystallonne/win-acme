﻿using PKISharp.WACS.DomainObjects;
using PKISharp.WACS.Plugins.Base.Options;
using PKISharp.WACS.Plugins.Interfaces;
using PKISharp.WACS.Services;
using System;
using System.Threading.Tasks;

namespace PKISharp.WACS.Plugins.Base.Factories.Null
{
    /// <summary>
    /// Null implementation
    /// </summary>
    internal class NullValidationFactory : IValidationPluginOptionsFactory, INull
    {
        Type IHasType.InstanceType => typeof(object);
        Type IHasType.OptionsType => typeof(object);
        string IValidationPluginOptionsFactory.ChallengeType => string.Empty;
        Task<ValidationPluginOptions> IValidationPluginOptionsFactory.Aquire(Target target, IInputService inputService, RunLevel runLevel) => null;
        Task<ValidationPluginOptions> IValidationPluginOptionsFactory.Default(Target target) => null;
        bool IHasName.Match(string name) => false;
        string IHasName.Name => "None";
        string IHasName.Description => null;
        bool IValidationPluginOptionsFactory.CanValidate(Target target) => false;
        public int Order => int.MaxValue;
        public bool Disabled => true;
    }
}
