using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using umbraco.businesslogic;
using umbraco.BusinessLogic.Actions;
using umbraco.cms.presentation.Trees;
using umbraco.interfaces;

namespace UmbracoMVCBackofficePages
{
    [Tree("settings", "exampleTree", "Example")]
    public class ExampleTree : BaseTree
    {
        public ExampleTree(string application)
            : base(application)
        {
        }

        protected override void CreateRootNode(ref XmlTreeNode rootNode)
        {
            rootNode.NodeType   = "example";
            rootNode.NodeID     = "init";
            rootNode.Menu =  new List<IAction> { ActionRefresh.Instance };
        }

        public override void Render(ref XmlTree tree)
        {

            foreach (var person in Data.GetAll())
            {
                var node = XmlTreeNode.Create(this);
                node.NodeID = person.Id.ToString();
                node.NodeType = "person";
                node.Text = person.ToString();
                node.Action = string.Format("javascript:openExamplePage({0});",
                    person.Id.ToString());
                node.Icon = "../../../App_Plugins/UmbracoMVCBackofficePages/Icons/example-icon.png";
                node.OpenIcon = "../../../App_Plugins/UmbracoMVCBackofficePages/Icons/example-icon.png";
                node.HasChildren = false;
                node.Menu = new List<IAction>();
                OnBeforeNodeRender(ref tree, ref node, EventArgs.Empty);
                if (node != null)
                {
                    tree.Add(node);
                    OnAfterNodeRender(ref tree, ref node, EventArgs.Empty);
                }

            }

        }

        public override void RenderJS(ref System.Text.StringBuilder Javascript)
        {
            Javascript.Append(
               @"function openExamplePage(id) {
                 UmbClientMgr.contentFrame('../App_Plugins/UmbracoMVCBackofficePages/Index?id='+id);
                }");
        }
    }
}