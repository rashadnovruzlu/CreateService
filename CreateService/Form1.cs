using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateService
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Model> _models = new List<Model>();


        private void btnShowModelFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            // folder.ShowDialog();
            txtModel.Text = @"D:\Git\DMS\src\Model\DB Tables";//folder.SelectedPath;

            foreach (var item in Directory.GetFiles(txtModel.Text))
            {
                Model model = new Model();
                model.FullName = item;
                string fileName = Path.GetFileName(item).Replace(".cs", "");
                model.ClassName = fileName;
                string[] s = fileName.Split('_');
                string name = String.Empty;
                if (s.Length == 1)
                {
                    name = MakeCapitalText(s[0]);
                }

                else if (s.Length > 1)
                {
                    for (int i = 1; i < s.Length; i++)
                    {
                        name += MakeCapitalText(s[i]);
                    }

                }
                model.Name = name;

                _models.Add(model);

                listBox1.Items.Add(fileName);
            }
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            foreach (var item in _models)
            {
                listBox2.Items.Add(item.Name);
            }
        }

        private void btnMake_Click(object sender, EventArgs e)
        {
            string repository, iRepository, service, Iservice;

            repository = File.ReadAllText(@"Demo/DemoRepository.cs");
            iRepository = File.ReadAllText(@"Demo/IDemoRepository.cs");
            service = File.ReadAllText(@"Demo/DemoService.cs");
            Iservice = File.ReadAllText(@"Demo/IDemoService.cs");

            string text, temp;
            string demoIdType = null, demoId = null;
            string keyWord1 = "public", keyWord2 = "get;", keyWord3 = "set;";
            string fileName, name;

            foreach (var item in _models)
            {
                text = File.ReadAllText(item.FullName);

                foreach (var line in text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
                {
                    if (line != null && line.IndexOf(keyWord1) > -1 && line.IndexOf(keyWord2) > -1 && line.IndexOf(keyWord3) > -1)
                    {
                        string[] l = line.Trim().Split(' ');

                        if (l.Length > 2)
                        {
                            demoIdType = l[1];
                            demoId = l[2];
                        }

                        break;
                    }
                }

                #region Repository

                temp = repository;

                fileName = item.Name + "Repository.cs";

                name = item.Name + "Repository";

                temp = temp
                       .Replace("DemoRepository", name)
                       .Replace("Demo_Class", item.ClassName)
                       .Replace("IDemoRepository", "I" + name)
                       .Replace("demoIdType", demoIdType)
                       .Replace("demoId", demoId);


                WriteFile(txtRepository.Text + "\\" + fileName, temp);

                #endregion

                #region IRepository
                temp = iRepository;

                fileName = "I" + item.Name + "Repository.cs";

                name = "I" + item.Name + "Repository";

                temp = temp
                       .Replace("IDemoRepository", name)
                       .Replace("Demo_Class", item.ClassName)
                       .Replace("demoIdType", demoIdType);

                WriteFile(txtRepository.Text + "\\" + fileName, temp);

                #endregion

                #region Service

                temp = service;

                fileName = item.Name + "Service.cs";

                name = item.Name + "Service";

                temp = temp
                       .Replace("DemoService", name)
                       .Replace("Demo_Class", item.ClassName)
                       .Replace("IDemoService", "I" + name)
                       .Replace("IDemoRepository", "I" + item.Name + "Repository")
                       .Replace("_demoRepository", "_" + item.Name.ToLower() + "Repository")
                       .Replace("ddemoRepository", item.Name.ToLower() + "Repository")
                       .Replace("demoIdType", demoIdType)
                       .Replace("demoId", demoId);


                WriteFile(txtService.Text + "\\" + fileName, temp);


                #endregion

                #region IService

                temp = Iservice;

                fileName = "I" + item.Name + "Service.cs";

                name = "I" + item.Name + "Service";

                temp = temp
                       .Replace("Demo_Class", item.ClassName)
                       .Replace("IDemoService", name)
                       .Replace("demoIdType", demoIdType);

                WriteFile(txtService.Text + "\\" + fileName, temp);


                #endregion

            }
        }


        private static void WriteFile(string path, string content)
        {

            //this code segment write data to file.
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fs);
            writer.Write(content);
            writer.Close();
        }

        private static string MakeCapitalText(string k)
        {
            string result = "";
            for (int i = 0; i < k.Length; i++)
            {
                result += i == 0 ? k[i].ToString().ToUpper() : k[i].ToString().ToLower();
            }

            return result;
        }

        private void btnShowRepoFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.ShowDialog();
            txtRepository.Text = folder.SelectedPath;
        }

        private void btnShowServiceFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.ShowDialog();
            txtService.Text = folder.SelectedPath;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                var item = listBox2.SelectedItem.ToString();
                _models.Remove(_models.Where(x => x.Name == item).First());
                listBox2.Items.Clear();
                foreach (var m in _models)
                {
                    listBox2.Items.Add(m.Name);
                }
            }

        }
    }
}
