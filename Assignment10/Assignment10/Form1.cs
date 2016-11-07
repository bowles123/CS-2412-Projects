using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Windows.Forms;
using System.IO;

namespace Assignment10
{
    public partial class Form1 : Form
    {
        string substringDirectory;
        string currentDirectory = Directory.GetCurrentDirectory();

        public Form1()
        {
            InitializeComponent();
        }

        // populate current node with subdirectories
        public void PopulateTreeView(
           string directoryValue, TreeNode parentNode)
        {
            // array stores all subdirectories in the directory
            string[] directoryArray =
               Directory.GetDirectories(directoryValue);

            // populate current node with subdirectories
            try
            {
                // check to see if any subdirectories are present
                if (directoryArray.Length != 0)
                {
                    // for every subdirectory, create new TreeNode,
                    // add as a child of current node and recursively
                    // populate child nodes with subdirectories
                    foreach (string directory in directoryArray)
                    {
                        // obtain last part of path name from the full path 
                        // name by calling the GetFileNameWithoutExtension
                        // method of class Path
                        substringDirectory =
                           Path.GetFileNameWithoutExtension(directory);

                        // create TreeNode for current directory
                        TreeNode myNode = new TreeNode(substringDirectory);

                        // add current directory node to parent node
                        parentNode.Nodes.Add(myNode);

                        // recursively populate every subdirectory
                        PopulateTreeView(directory, myNode);
                    }
                }
            }

            // catch exception
            catch (UnauthorizedAccessException)
            {
                parentNode.Nodes.Add("Access denied");
            }
        }

        async private void pathEnterButton_Click(object sender, System.EventArgs e)
        {
            // clear all nodes
            directoryTreeView.Nodes.Clear();

            // check if the directory entered by user exists
            // if it does then fill in the TreeView,
            // if not display error MessageBox
            if (Directory.Exists(pathTextBox.Text))
            {
                // add full path name to directoryTreeView 
                directoryTreeView.Nodes.Add(pathTextBox.Text);

                // insert subfolders
                PopulateTreeView(
                   pathTextBox.Text, directoryTreeView.Nodes[0]);
            }
            // display error MessageBox if directory not found
            else
                MessageBox.Show(pathTextBox.Text + " could not be found.",
                   "Directory Not Found", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
        }

        async private void deleteButton_Click(object sender, System.EventArgs e)
        {

        }

        async private void browserListView_Click(object sender, System.EventArgs e)
        {
            // ensure an item is selected
            if (browserListView.SelectedItems.Count != 0)
            {
                // if first item selected, go up one level
                if (browserListView.Items[0].Selected)
                {
                    // create DirectoryInfo object for directory
                    DirectoryInfo directoryObject =
                       new DirectoryInfo(currentDirectory);

                    // if directory has parent, load it
                    if (directoryObject.Parent != null)
                    {
                        LoadFilesInDirectory(
                           directoryObject.Parent.FullName);
                    }
                }

                // selected directory or file
                else
                {
                    // directory or file chosen
                    string chosen = browserListView.SelectedItems[0].Text;

                    // if item selected is directory, load selected directory
                    if (Directory.Exists(
                       Path.Combine(currentDirectory, chosen)))
                    {
                        LoadFilesInDirectory(
                           Path.Combine(currentDirectory, chosen));
                    }
                }

                // update displayLabel
                displayLabel.Text = currentDirectory;
            } 
        }

        public void LoadFilesInDirectory(string currentDirectoryValue)
        {
            // load directory information and display
            try
            {
                // clear ListView and set first item
                browserListView.Items.Clear();
                browserListView.Items.Add("Go Up One Level");

                // update current directory
                currentDirectory = currentDirectoryValue;
                DirectoryInfo newCurrentDirectory =
                   new DirectoryInfo(currentDirectory);

                // put files and directories into arrays
                DirectoryInfo[] directoryArray =
                   newCurrentDirectory.GetDirectories();
                FileInfo[] fileArray = newCurrentDirectory.GetFiles();

                // add directory names to ListView
                foreach (DirectoryInfo dir in directoryArray)
                {
                    // add directory to ListView
                    ListViewItem newDirectoryItem =
                       browserListView.Items.Add(dir.Name);

                    newDirectoryItem.ImageIndex = 0;  // set directory image
                }

                // add file names to ListView
                foreach (FileInfo file in fileArray)
                {
                    // add file to ListView
                    ListViewItem newFileItem =
                       browserListView.Items.Add(file.Name);

                    newFileItem.ImageIndex = 1;  // set file image
                }
            }

            // access denied
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Warning: Some files may not be " +
                   "visible due to permission settings",
                   "Attention", 0, MessageBoxIcon.Warning);
            }
        }

        async private void Form1_Load(object sender, System.EventArgs e)
        {
            // add images to ImageList
            fileFolderImageList.Images.Add(Properties.Resources.folder);
            fileFolderImageList.Images.Add(Properties.Resources.file);

            // load current directory into browserListView
            LoadFilesInDirectory(currentDirectory);
            displayLabel.Text = currentDirectory;
        }
 

    }
}
