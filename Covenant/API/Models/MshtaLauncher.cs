// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Covenant.API.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class MshtaLauncher
    {
        /// <summary>
        /// Initializes a new instance of the MshtaLauncher class.
        /// </summary>
        public MshtaLauncher()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MshtaLauncher class.
        /// </summary>
        /// <param name="scriptLanguage">Possible values include: 'JScript',
        /// 'VBScript'</param>
        /// <param name="dotNetFrameworkVersion">Possible values include:
        /// 'Net40', 'Net35', 'NetCore21'</param>
        /// <param name="type">Possible values include: 'Wmic', 'Regsvr32',
        /// 'Mshta', 'Cscript', 'Wscript', 'PowerShell', 'Binary', 'MSBuild',
        /// 'InstallUtil'</param>
        /// <param name="commType">Possible values include: 'HTTP',
        /// 'SMB'</param>
        public MshtaLauncher(ScriptingLanguage? scriptLanguage = default(ScriptingLanguage?), string progId = default(string), string diskCode = default(string), int? id = default(int?), int? listenerId = default(int?), DotNetVersion? dotNetFrameworkVersion = default(DotNetVersion?), LauncherType? type = default(LauncherType?), string name = default(string), string description = default(string), CommunicationType? commType = default(CommunicationType?), bool? validateCert = default(bool?), bool? useCertPinning = default(bool?), string smbPipeName = default(string), int? delay = default(int?), int? jitterPercent = default(int?), int? connectAttempts = default(int?), System.DateTime? killDate = default(System.DateTime?), string launcherString = default(string), string stagerCode = default(string), string base64ILByteString = default(string))
        {
            ScriptLanguage = scriptLanguage;
            ProgId = progId;
            DiskCode = diskCode;
            Id = id;
            ListenerId = listenerId;
            DotNetFrameworkVersion = dotNetFrameworkVersion;
            Type = type;
            Name = name;
            Description = description;
            CommType = commType;
            ValidateCert = validateCert;
            UseCertPinning = useCertPinning;
            SmbPipeName = smbPipeName;
            Delay = delay;
            JitterPercent = jitterPercent;
            ConnectAttempts = connectAttempts;
            KillDate = killDate;
            LauncherString = launcherString;
            StagerCode = stagerCode;
            Base64ILByteString = base64ILByteString;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'JScript', 'VBScript'
        /// </summary>
        [JsonProperty(PropertyName = "scriptLanguage")]
        public ScriptingLanguage? ScriptLanguage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "progId")]
        public string ProgId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "diskCode")]
        public string DiskCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "listenerId")]
        public int? ListenerId { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Net40', 'Net35', 'NetCore21'
        /// </summary>
        [JsonProperty(PropertyName = "dotNetFrameworkVersion")]
        public DotNetVersion? DotNetFrameworkVersion { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Wmic', 'Regsvr32', 'Mshta',
        /// 'Cscript', 'Wscript', 'PowerShell', 'Binary', 'MSBuild',
        /// 'InstallUtil'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public LauncherType? Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'HTTP', 'SMB'
        /// </summary>
        [JsonProperty(PropertyName = "commType")]
        public CommunicationType? CommType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "validateCert")]
        public bool? ValidateCert { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "useCertPinning")]
        public bool? UseCertPinning { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "smbPipeName")]
        public string SmbPipeName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "delay")]
        public int? Delay { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "jitterPercent")]
        public int? JitterPercent { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "connectAttempts")]
        public int? ConnectAttempts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "killDate")]
        public System.DateTime? KillDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "launcherString")]
        public string LauncherString { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stagerCode")]
        public string StagerCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "base64ILByteString")]
        public string Base64ILByteString { get; set; }

    }
}
