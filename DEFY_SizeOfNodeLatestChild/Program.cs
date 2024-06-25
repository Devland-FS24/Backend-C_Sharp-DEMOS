using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEFY_SizeOfNodeLatestChild
{
    class Program
    {
        static void Main(string[] args)
        {
            var myTreeNode = new TreeNode();
            
            //        var filteredNodes = Fix<IEnumerable<TreeNode>>(
            //f =>
            //nodeList =>
            //nodeList.SelectMany(node => f(node.ChildNodes.Cast<TreeNode>()))
            //  .Union(nodeList.Where(filterStartWithXorNoData)))
            //  (tv.Nodes.Cast<TreeNode>());

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
        }

        // Fix point operator
        public static Func<T, T> Fix<T>(Func<Func<T, T>, Func<T, T>> f)
        {
            return t => f(Fix<T>(f))(t);
        }
    }
}
