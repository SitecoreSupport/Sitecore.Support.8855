namespace Sitecore.Support.XA.Feature.CreativeExchange.Pipelines.Export.PageProcessing
{
    using System.Text.RegularExpressions;
    using Sitecore.XA.Feature.CreativeExchange.Pipelines.Export.PageProcessing;

    public class PageAssetExtract : Sitecore.XA.Feature.CreativeExchange.Pipelines.Export.PageProcessing.PageAssetExtract
    {
        protected override void ProcessLink(PageProcessingArgs args, string link, string tag, Match match)
        {
            if (!link.Contains("tel:"))
            {
                base.ProcessLink(args, link, tag, match);
            }
        }
    }
}