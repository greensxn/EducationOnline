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
    
    public partial class TopicFiles
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TopicFiles()
        {
            this.Tests = new HashSet<Tests>();
            this.UserTopicFileDones = new HashSet<UserTopicFileDones>();
        }
    
        public int Id { get; set; }
        public Nullable<int> CourseTopicId { get; set; }
        public Nullable<int> FileTypeId { get; set; }
        public Nullable<int> CourseId { get; set; }
        public string Name { get; set; }
        public Nullable<bool> IsTest { get; set; }
    
        public virtual Courses Courses { get; set; }
        public virtual CourseTopics CourseTopics { get; set; }
        public virtual FileTypes FileTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tests> Tests { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserTopicFileDones> UserTopicFileDones { get; set; }
    }
}
