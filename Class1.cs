using System;
using System.Collections.Generic;

namespace StandardConfData
{
    namespace MyInfo
    {
        //以下 enumeration 已实现，参考 Record2 项目 Class1.vb 文件直接转制
        public enum AppStatus; 
        public enum FileCategory;
        public enum YieldTo;
        public enum WorkLanguage;
        public enum UsingRule;
        public enum TopicSelection;
        public enum VoteOpinion;

        [Serializable]
        public class Conference
        {
            public WorkLanguage Language { get; set; }
            public TopicSelection TopicSel { get; private set; }
            public UsingRule MyRule { get; set; }
            public int XmlVersion { get; set; }
            public string ConferenceTitle { get; set; }
            public string Committee { get; set; }
            public string[] Topic = new string[1];
            public Record.RecordCollection ConferenceRecords = new Record.RecordCollection(); //会议记录类参考 Record2 项目 CodeFile1.vb 文件

            public int Session { get; private set; }


            public Conference(string title, string committee, string topic, WorkLanguage lang) //新建单议题会议
            {
                //...
                TopicSel = 0;
            }

            public Conference(string title, string committee, string topic1, string topic2, WorkLanguage lang) //新建双议题会议
            {
                //...
                TopicSel = 2;
            }

            public string GetTopic
            {
                get
                {
                    if (TopicSel < 2) return Topic[TopicSel];
                    return "议题等待决定中";
                }
            }
        }

        public class Nation
        {
            //本Nation类兼容在线系统中的国家类
            //以下属性参考class1.vb
            private int comp = 1;
            public string Name { get; set; }
            public List<Delegate> Delegates = new List<Delegate>();
            public int Competence
            {
                get
                {
                    return comp;
                }
                set
                {
                    comp = value;
                }
            } //默认值为1
            public string PresentationPaper { get; set; }
            public bool Attendence { get; set; }
            public bool VetoPower { get; set; }

            public static Nation Empty = null;

            public Nation() { }
            public Nation(string name) { }
            public Nation(string name, int competence) { }
            public Nation(string name, int competence, bool VetoPower) { }
            public Nation(string name, List<Delegate> delegates) { }
            public Nation(string name, List<Delegate> delegates, int competence) { }
            public Nation(string name, List<Delegate> delegates, int competence, bool VetoPower) { }

            //以下方法参考class1.vb
            public string GetDelegateNames(string delimiter) { }
            public string GetCompetence() { }
            public override string ToString()
            {
                return Name;
            }
        }

        public class Delegate
        {
            //兼容在线系统中的代表类，本API中使用以下数据：
            //1. 代表姓名；
            //2. 学校；
            //3. 年级。
        }

        public class NationList : List<Nation>
        {
            public int GetAttendentNumber()
            {
                int a = 0;
                foreach (Nation i in this)
                {
                    if (i.Attendence == true) a++;
                }
                return a;
            }
        }

        public class SpeakersList
        {
            public int slTime { get; set; }
            public int slCurrent { get; private set; }
            public NationList slNations = new NationList();
            public List<int> slIsSpoken = new List<int>();
            public List<YieldTo> yieldMethod = new List<YieldTo>();

            public SpeakersList() //默认120s创建新SpeakersList类
            {
                slTime = 120;
            }

            public SpeakersList(int time) //指定发言时长创建新SpeakersList类
            {
                slTime = time;
            }

            public int AddNation(Nation nat) //添加国家
            {
                slNations.Add(nat);
                slTotal += 1;
                return slTotal;
            }

            public int SpeakNext() //发言转向下一个国家
            {
                slCurrent++;
                return slCurrent;
            }
        }

        public class File
        {
            //已全部实现，查看class1.vb
        }

        public class FileList : List<File>
        {
            //已全部实现，查看class1.vb
        }
    }
}

