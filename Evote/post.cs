//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Evote
{
    using System;
    using System.Collections.Generic;
    
    public partial class post
    {
        public int Id { get; set; }
        public string postTitle { get; set; }
        public string postDescription { get; set; }
        public string postImageName { get; set; }
        public byte[] postImageContent { get; set; }
        public string postImageFileType { get; set; }
        public Nullable<System.DateTime> startDate { get; set; }
        public Nullable<System.DateTime> closeDate { get; set; }
        public Nullable<int> numberOfContestants { get; set; }
        public Nullable<bool> voteStatus { get; set; }
    }
}