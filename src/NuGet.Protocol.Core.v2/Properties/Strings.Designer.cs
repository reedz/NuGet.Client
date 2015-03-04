// <auto-generated />
namespace NuGet.Protocol.Core.v2
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class Strings
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("NuGet.Protocol.Core.v2.Strings", typeof(Strings).GetTypeInfo().Assembly);

        /// <summary>
        /// Install failed. Rolling back...
        /// </summary>
        internal static string ActionExecutor_RollingBack
        {
            get { return GetString("ActionExecutor_RollingBack"); }
        }

        /// <summary>
        /// Install failed. Rolling back...
        /// </summary>
        internal static string FormatActionExecutor_RollingBack()
        {
            return GetString("ActionExecutor_RollingBack");
        }

        /// <summary>
        /// Unrecognized Package Action '{0}'.
        /// </summary>
        internal static string ActionResolver_UnsupportedAction
        {
            get { return GetString("ActionResolver_UnsupportedAction"); }
        }

        /// <summary>
        /// Unrecognized Package Action '{0}'.
        /// </summary>
        internal static string FormatActionResolver_UnsupportedAction(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ActionResolver_UnsupportedAction"), p0);
        }

        /// <summary>
        /// Unsupported Dependency Behavior '{0}'.
        /// </summary>
        internal static string ActionResolver_UnsupportedDependencyBehavior
        {
            get { return GetString("ActionResolver_UnsupportedDependencyBehavior"); }
        }

        /// <summary>
        /// Unsupported Dependency Behavior '{0}'.
        /// </summary>
        internal static string FormatActionResolver_UnsupportedDependencyBehavior(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ActionResolver_UnsupportedDependencyBehavior"), p0);
        }

        /// <summary>
        /// The download URL for {0} '{1}' is invalid.
        /// </summary>
        internal static string DownloadActionHandler_InvalidDownloadUrl
        {
            get { return GetString("DownloadActionHandler_InvalidDownloadUrl"); }
        }

        /// <summary>
        /// The download URL for {0} '{1}' is invalid.
        /// </summary>
        internal static string FormatDownloadActionHandler_InvalidDownloadUrl(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("DownloadActionHandler_InvalidDownloadUrl"), p0, p1);
        }

        /// <summary>
        /// No download URL could be found for {0}.
        /// </summary>
        internal static string DownloadActionHandler_NoDownloadUrl
        {
            get { return GetString("DownloadActionHandler_NoDownloadUrl"); }
        }

        /// <summary>
        /// No download URL could be found for {0}.
        /// </summary>
        internal static string FormatDownloadActionHandler_NoDownloadUrl(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("DownloadActionHandler_NoDownloadUrl"), p0);
        }

        /// <summary>
        /// Cannot create a NuGet Repository from the Aggregate Source
        /// </summary>
        internal static string NuGetRepository_CannotCreateAggregateRepo
        {
            get { return GetString("NuGetRepository_CannotCreateAggregateRepo"); }
        }

        /// <summary>
        /// Cannot create a NuGet Repository from the Aggregate Source
        /// </summary>
        internal static string FormatNuGetRepository_CannotCreateAggregateRepo()
        {
            return GetString("NuGetRepository_CannotCreateAggregateRepo");
        }

        /// <summary>
        /// The {0} service is not supported by this object.
        /// </summary>
        internal static string NuGetServiceProvider_ServiceNotSupported
        {
            get { return GetString("NuGetServiceProvider_ServiceNotSupported"); }
        }

        /// <summary>
        /// The {0} service is not supported by this object.
        /// </summary>
        internal static string FormatNuGetServiceProvider_ServiceNotSupported(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("NuGetServiceProvider_ServiceNotSupported"), p0);
        }

        /// <summary>
        /// Unrecognized Package Action '{0}'.
        /// </summary>
        internal static string PackageActionDescriptionWrapper_UnrecognizedAction
        {
            get { return GetString("PackageActionDescriptionWrapper_UnrecognizedAction"); }
        }

        /// <summary>
        /// Unrecognized Package Action '{0}'.
        /// </summary>
        internal static string FormatPackageActionDescriptionWrapper_UnrecognizedAction(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("PackageActionDescriptionWrapper_UnrecognizedAction"), p0);
        }

        /// <summary>
        /// The project '{0}' is not one of the projects targetted by this object.
        /// </summary>
        internal static string ProjectInstallationTarget_ProjectIsNotTargetted
        {
            get { return GetString("ProjectInstallationTarget_ProjectIsNotTargetted"); }
        }

        /// <summary>
        /// The project '{0}' is not one of the projects targetted by this object.
        /// </summary>
        internal static string FormatProjectInstallationTarget_ProjectIsNotTargetted(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ProjectInstallationTarget_ProjectIsNotTargetted"), p0);
        }

        /// <summary>
        /// Service index document is missing the 'resources' property.
        /// </summary>
        internal static string Protocol_IndexMissingResourcesNode
        {
            get { return GetString("Protocol_IndexMissingResourcesNode"); }
        }

        /// <summary>
        /// Service index document is missing the 'resources' property.
        /// </summary>
        internal static string FormatProtocol_IndexMissingResourcesNode()
        {
            return GetString("Protocol_IndexMissingResourcesNode");
        }

        /// <summary>
        /// The source does not have a Registration Base Url defined!
        /// </summary>
        internal static string Protocol_MissingRegistrationBase
        {
            get { return GetString("Protocol_MissingRegistrationBase"); }
        }

        /// <summary>
        /// The source does not have a Registration Base Url defined!
        /// </summary>
        internal static string FormatProtocol_MissingRegistrationBase()
        {
            return GetString("Protocol_MissingRegistrationBase");
        }

        /// <summary>
        /// The source does not have a Search service!
        /// </summary>
        internal static string Protocol_MissingSearchService
        {
            get { return GetString("Protocol_MissingSearchService"); }
        }

        /// <summary>
        /// The source does not have a Search service!
        /// </summary>
        internal static string FormatProtocol_MissingSearchService()
        {
            return GetString("Protocol_MissingSearchService");
        }

        /// <summary>
        /// The '{0}' installation feature was required by a package but is not supported on the current host.
        /// </summary>
        internal static string RequiredFeatureUnsupportedException_DefaultMessageWithFeature
        {
            get { return GetString("RequiredFeatureUnsupportedException_DefaultMessageWithFeature"); }
        }

        /// <summary>
        /// The '{0}' installation feature was required by a package but is not supported on the current host.
        /// </summary>
        internal static string FormatRequiredFeatureUnsupportedException_DefaultMessageWithFeature(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("RequiredFeatureUnsupportedException_DefaultMessageWithFeature"), p0);
        }

        /// <summary>
        /// The installation host does not support a feature required by this package.
        /// </summary>
        internal static string RequiredFeatureUnsupportedException_DefaultMessageWithoutFeature
        {
            get { return GetString("RequiredFeatureUnsupportedException_DefaultMessageWithoutFeature"); }
        }

        /// <summary>
        /// The installation host does not support a feature required by this package.
        /// </summary>
        internal static string FormatRequiredFeatureUnsupportedException_DefaultMessageWithoutFeature()
        {
            return GetString("RequiredFeatureUnsupportedException_DefaultMessageWithoutFeature");
        }

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            System.Diagnostics.Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
