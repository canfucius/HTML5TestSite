using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Default
/// </summary>
/// 
namespace ViewModels
{
    public class Default
    {

        public Default()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public Default(string desc, string sop1, string sop2, string sop3)
        {
            Description = desc;
            SelectedOp1 = sop1;
            SelectedOp2 = sop2;
            SelectedOp3 = sop3;
        }

        public string Description { get; set; }
        public string SelectedOp1 { get; set; }
        public string SelectedOp2 { get; set; }
        public string SelectedOp3 { get; set; }
        public List<string> Option1 { get; set; }
        public List<string> Option2 { get; set; }
        public List<string> Option3 { get; set; }

        public void Save()
        {
            Models.Mainpage mp = new Models.Mainpage(0, Description, new DateTime?(DateTime.Now), SelectedOp1, SelectedOp2);
            mp.Save();
        }
    }
}