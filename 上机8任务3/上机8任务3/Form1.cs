using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace 上机8任务3
{
    public partial class ExplorerForm : Form
    {
        public ExplorerForm()
        {
            InitializeComponent();
        }

        private void ExplorerForm_Load(object sender, EventArgs e)
        {
            TreeNode Computer = new TreeNode("我的电脑");
            trvExplorer.Nodes.Add(Computer);
           
            XmlDocument xml = new XmlDocument();
            xml.Load("Explorer.xml");
            XmlNode explorer = xml.DocumentElement;
            foreach (XmlNode node in explorer.ChildNodes)
            {
                string name = node.Attributes["name"].Value;
                TreeNode child = new TreeNode(name);
                foreach (XmlNode n in node.ChildNodes)
                {
                    child.Nodes.Add(n.Attributes["name"].Value);
                }
                trvExplorer.TopNode.Nodes.Add(child);
                
            }
        }
    }
}
