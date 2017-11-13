﻿using System.Web.Optimization;

namespace BuildMonitor
{
	public class BundleConfig
	{
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery-{version}.js"));
			bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include("~/Scripts/jquery.validate*"));
			bundles.Add(new ScriptBundle("~/bundles/home").Include("~/Scripts/Project/common.js", "~/Scripts/Project/builds.js", "~/Scripts/Project/tests.js", "~/Scripts/Project/lastUpdateWarning.js", "~/Scripts/Project/statisticsPie.js"));
			bundles.Add(new ScriptBundle("~/bundles/automation").Include("~/Scripts/Project/common.js", "~/Scripts/Project/automation.js"));

			bundles.Add(new ScriptBundle("~/bundles/modernizr").Include("~/Scripts/modernizr-*"));
			bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include("~/Scripts/bootstrap.js", "~/Scripts/respond.js"));
			bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/bootstrap.css", "~/Content/site.css"));
		}
	}
}