//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DistanceLearning.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserTopicFileDones
    {
        public int Id { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> CourseId { get; set; }
        public Nullable<int> TopicFileId { get; set; }
    
        public virtual Courses Courses { get; set; }
        public virtual TopicFiles TopicFiles { get; set; }
        public virtual Users Users { get; set; }
    }
}
