using System;
using System.IO;
using FileHelper;
using JSystem.Perform;
using JLogging;

namespace JSystem.Project
{
    public class ProjectManager
    {
        private readonly string _prosFile = AppDomain.CurrentDomain.BaseDirectory + "Project\\Pros.xml";

        private readonly string _devicesCfg = AppDomain.CurrentDomain.BaseDirectory + "Project\\Devices.xml";
        
        public Func<string, bool> OnSaveProject;
        
        public Func<string, bool> OnLoadProject;

        public Projects Projects;

        public string ProjectPath
        {
            get
            {
                return AppDomain.CurrentDomain.BaseDirectory + "Project\\" + Projects.CurrProject + ".json";
            }
        }

        public ProjectManager()
        {
            try
            {
                Projects = new Projects();
                if (!File.Exists(_prosFile))
                    return;
                Projects = XMLHelper.Deserialize<Projects>(_prosFile);
                LoadProject(Projects.CurrProject);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool SaveProject(string projectName)
        {
            if (!Projects.ProjectsName.Contains(projectName))
                Projects.ProjectsName.Add(projectName);
            string fileDir = AppDomain.CurrentDomain.BaseDirectory + "Project\\";
            if (!Directory.Exists(fileDir))
                Directory.CreateDirectory(fileDir);
            Projects.CurrProject = projectName;
            if (!OnSaveProject(ProjectPath))
            {
                LogManager.Instance.AddLog("工单", $"产品{projectName}参数失败", LogLevels.Error);
                return false;
            }
            XMLHelper.Serialize(Projects, _prosFile);
            LogManager.Instance.AddLog("工单", $"产品{projectName}参数已保存", LogLevels.Debug);
            return true;
        }

        public bool LoadProject(string projectName = "")
        {
            projectName = projectName == "" ? Projects.CurrProject : projectName;
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "Project\\" + projectName + ".json";
            if (!File.Exists(filePath))
                return false;
            if (OnLoadProject == null || !OnLoadProject(filePath))
                return false;
            Projects.CurrProject = projectName;
            XMLHelper.Serialize(Projects, _prosFile);
            LogManager.Instance.AddLog("工单", $"当前产品切换为{projectName}", LogLevels.Debug);
            return true;
        }

        public void DeleteProject(string projectName)
        {
            Projects.ProjectsName.Remove(Projects.CurrProject);
            Projects.CurrProject = "";
            string fileDir = AppDomain.CurrentDomain.BaseDirectory + "Project\\";
            File.Delete(fileDir + projectName + ".json");
            XMLHelper.Serialize(Projects, _prosFile);
            LogManager.Instance.AddLog("工单", $"产品{projectName}参数已删除", LogLevels.Debug);
        }
    }
}
