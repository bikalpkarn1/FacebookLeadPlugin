using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeoCrmPlugin.Web.Models
{
    public class DropdownModel1
    {
        public int AgentId { get; set; }
        //public List<DropdownModel> AgentSelectList { get; set; }
        public SelectList AgentSelectList { get; set; }
        public int ProductId { get; set; }
        // public List<DropdownModel> ProductSelectList { get; set; }
        public SelectList ProductSelectList { get; set; }
        public int RatingId { get; set; }
        // public List<DropdownModel> RatingSelectList { get; set; }
        public SelectList RatingSelectList { get; set; }
    }
    public class FormDataModel
    {
        public string AgentId { get; set; }
        public string ProductId { get; set; }
        public string RatingId { get; set; }
        public List<FormModel> FormData { get; set; }
    }
    public class FormModel
    {
        public string LeadName { get; set; }
        public string LeadSubject { get; set; }
        public string LeadDescription { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }
    }
}
