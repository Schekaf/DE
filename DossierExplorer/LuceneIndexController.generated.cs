// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo. Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
// 0114: suppress "Foo.BarController.Baz()' hides inherited member 'Qux.BarController.Baz()'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword." when an action (with an argument) overrides an action in a parent controller
#pragma warning disable 1591, 3008, 3009, 0108, 0114
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace DossierExplorer.Controllers
{
    public partial class LuceneIndexController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public LuceneIndexController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected LuceneIndexController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(Task<ActionResult> taskResult)
        {
            return RedirectToAction(taskResult.Result);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(Task<ActionResult> taskResult)
        {
            return RedirectToActionPermanent(taskResult.Result);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.PartialViewResult _PartialUserSearchFiles()
        {
            return new T4MVC_System_Web_Mvc_PartialViewResult(Area, Name, ActionNames._PartialUserSearchFiles);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.PartialViewResult _PartialContent()
        {
            return new T4MVC_System_Web_Mvc_PartialViewResult(Area, Name, ActionNames._PartialContent);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult AddTag()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.AddTag);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult DeleteTag()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.DeleteTag);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public LuceneIndexController Actions { get { return MVC.LuceneIndex; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "LuceneIndex";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "LuceneIndex";
        [GeneratedCode("T4MVC", "2.0")]
        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string LuceneIndex = "LuceneIndex";
            public readonly string _PartialUserSearchFiles = "_PartialUserSearchFiles";
            public readonly string _PartialContent = "_PartialContent";
            public readonly string AddTag = "AddTag";
            public readonly string DeleteTag = "DeleteTag";
            public readonly string SearchInfo = "SearchInfo";
            public readonly string FileBrowserInfo = "FileBrowserInfo";
            public readonly string _PartialTags = "_PartialTags";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string LuceneIndex = "LuceneIndex";
            public const string _PartialUserSearchFiles = "_PartialUserSearchFiles";
            public const string _PartialContent = "_PartialContent";
            public const string AddTag = "AddTag";
            public const string DeleteTag = "DeleteTag";
            public const string SearchInfo = "SearchInfo";
            public const string FileBrowserInfo = "FileBrowserInfo";
            public const string _PartialTags = "_PartialTags";
        }


        static readonly ActionParamsClass__PartialUserSearchFiles s_params__PartialUserSearchFiles = new ActionParamsClass__PartialUserSearchFiles();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass__PartialUserSearchFiles _PartialUserSearchFilesParams { get { return s_params__PartialUserSearchFiles; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass__PartialUserSearchFiles
        {
            public readonly string SearchTerm = "SearchTerm";
            public readonly string SearchField = "SearchField";
            public readonly string RecordCount = "RecordCount";
            public readonly string Page = "Page";
            public readonly string SortOrder = "SortOrder";
            public readonly string Tags = "Tags";
        }
        static readonly ActionParamsClass__PartialContent s_params__PartialContent = new ActionParamsClass__PartialContent();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass__PartialContent _PartialContentParams { get { return s_params__PartialContent; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass__PartialContent
        {
            public readonly string fullpath = "fullpath";
        }
        static readonly ActionParamsClass_AddTag s_params_AddTag = new ActionParamsClass_AddTag();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_AddTag AddTagParams { get { return s_params_AddTag; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_AddTag
        {
            public readonly string paths = "paths";
            public readonly string tag = "tag";
        }
        static readonly ActionParamsClass_DeleteTag s_params_DeleteTag = new ActionParamsClass_DeleteTag();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_DeleteTag DeleteTagParams { get { return s_params_DeleteTag; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_DeleteTag
        {
            public readonly string paths = "paths";
            public readonly string tag = "tag";
        }
        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
                public readonly string _PartialContent = "_PartialContent";
                public readonly string _PartialTags = "_PartialTags";
                public readonly string _PartialUserSearchFiles = "_PartialUserSearchFiles";
                public readonly string FileBrowserInfo = "FileBrowserInfo";
                public readonly string LuceneIndex = "LuceneIndex";
                public readonly string SearchInfo = "SearchInfo";
            }
            public readonly string _PartialContent = "~/Views/LuceneIndex/_PartialContent.cshtml";
            public readonly string _PartialTags = "~/Views/LuceneIndex/_PartialTags.cshtml";
            public readonly string _PartialUserSearchFiles = "~/Views/LuceneIndex/_PartialUserSearchFiles.cshtml";
            public readonly string FileBrowserInfo = "~/Views/LuceneIndex/FileBrowserInfo.cshtml";
            public readonly string LuceneIndex = "~/Views/LuceneIndex/LuceneIndex.cshtml";
            public readonly string SearchInfo = "~/Views/LuceneIndex/SearchInfo.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_LuceneIndexController : DossierExplorer.Controllers.LuceneIndexController
    {
        public T4MVC_LuceneIndexController() : base(Dummy.Instance) { }

        [NonAction]
        partial void LuceneIndexOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult LuceneIndex()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.LuceneIndex);
            LuceneIndexOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void _PartialUserSearchFilesOverride(T4MVC_System_Web_Mvc_PartialViewResult callInfo, string SearchTerm, string SearchField, string RecordCount, int? Page, string SortOrder, string[] Tags);

        [NonAction]
        public override System.Web.Mvc.PartialViewResult _PartialUserSearchFiles(string SearchTerm, string SearchField, string RecordCount, int? Page, string SortOrder, string[] Tags)
        {
            var callInfo = new T4MVC_System_Web_Mvc_PartialViewResult(Area, Name, ActionNames._PartialUserSearchFiles);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "SearchTerm", SearchTerm);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "SearchField", SearchField);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "RecordCount", RecordCount);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "Page", Page);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "SortOrder", SortOrder);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "Tags", Tags);
            _PartialUserSearchFilesOverride(callInfo, SearchTerm, SearchField, RecordCount, Page, SortOrder, Tags);
            return callInfo;
        }

        [NonAction]
        partial void _PartialContentOverride(T4MVC_System_Web_Mvc_PartialViewResult callInfo, string fullpath);

        [NonAction]
        public override System.Web.Mvc.PartialViewResult _PartialContent(string fullpath)
        {
            var callInfo = new T4MVC_System_Web_Mvc_PartialViewResult(Area, Name, ActionNames._PartialContent);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "fullpath", fullpath);
            _PartialContentOverride(callInfo, fullpath);
            return callInfo;
        }

        [NonAction]
        partial void AddTagOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string[] paths, string tag);

        [NonAction]
        public override System.Web.Mvc.ActionResult AddTag(string[] paths, string tag)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.AddTag);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "paths", paths);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "tag", tag);
            AddTagOverride(callInfo, paths, tag);
            return callInfo;
        }

        [NonAction]
        partial void DeleteTagOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string[] paths, string tag);

        [NonAction]
        public override System.Web.Mvc.ActionResult DeleteTag(string[] paths, string tag)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.DeleteTag);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "paths", paths);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "tag", tag);
            DeleteTagOverride(callInfo, paths, tag);
            return callInfo;
        }

        [NonAction]
        partial void SearchInfoOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult SearchInfo()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SearchInfo);
            SearchInfoOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void FileBrowserInfoOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult FileBrowserInfo()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.FileBrowserInfo);
            FileBrowserInfoOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void _PartialTagsOverride(T4MVC_System_Web_Mvc_PartialViewResult callInfo);

        [NonAction]
        public override System.Web.Mvc.PartialViewResult _PartialTags()
        {
            var callInfo = new T4MVC_System_Web_Mvc_PartialViewResult(Area, Name, ActionNames._PartialTags);
            _PartialTagsOverride(callInfo);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108, 0114
