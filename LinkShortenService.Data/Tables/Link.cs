//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LinkShortenService.Data.Tables
{
    using System;
    using System.Collections.Generic;
    
    public partial class Link
    {
        public int LinkId { get; set; }
        public string OriginUrl { get; set; }
        public string ShortсutUrl { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public int FollowingCount { get; set; }
    }
}
