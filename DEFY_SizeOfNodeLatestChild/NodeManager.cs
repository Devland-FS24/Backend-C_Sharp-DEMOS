using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEFY_SizeOfNodeLatestChild
{
    public static class NodeManager
    {

        public static IEnumerable<TreeNode> GetDeepestChildren(TreeNode myTreeNode)
        {
            Func<TreeNode, IEnumerable<TreeNode>> getChildren = null;
            getChildren = n => {
                if (n.Nodes.Count != 0)
                {
                    var list = new List<TreeNode>(n.Nodes.Cast<TreeNode>().Where(c => c.Nodes.Count == 0));
                    foreach (var c in n.Nodes)
                    {
                        // Note the recursive call below:
                        list.AddRange(getChildren((TreeNode)c));
                    }
                    return list;
                }
                else
                {
                    return new TreeNode[0];
                }
            };
            var res = getChildren(myTreeNode);

            return res;

        }


    }
}
