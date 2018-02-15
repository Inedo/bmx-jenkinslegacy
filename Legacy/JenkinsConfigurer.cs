using System;
using Inedo.BuildMaster.Extensibility.Configurers.Extension;
using Inedo.Extensions.Jenkins;
using Inedo.Serialization;
using Inedo.Web;

[assembly: ExtensionConfigurer(typeof(Inedo.BuildMasterExtensions.Jenkins.JenkinsConfigurer))]

namespace Inedo.BuildMasterExtensions.Jenkins
{
    [Serializable]
    [CustomEditor(typeof(JenkinsConfigurerEditor))]
    [PersistFrom("Inedo.BuildMasterExtensions.Jenkins.JenkinsConfigurer,Jenkins")]
    public sealed class JenkinsConfigurer : ExtensionConfigurerBase, IJenkinsConnectionInfo
    {
        string IJenkinsConnectionInfo.UserName => this.Username; // Rubbish casing

        [Persistent]
        public string ServerUrl { get; set; }

        [Persistent]
        public string Username { get; set; }

        [Persistent(Encrypted = true)]
        public string Password { get; set; }
    }
}
