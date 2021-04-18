﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class Consulting
{
    public int ID { get; set; }
    public int UserID { get; set; }
    public System.DateTime SendDate { get; set; }
    public string Symptoms { get; set; }
    public string Keywords { get; set; }
    public string Reply { get; set; }
    public Nullable<System.DateTime> ReplyDate { get; set; }

    public virtual User User { get; set; }
}

public partial class Post
{
    public int ID { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public System.DateTime CreationDate { get; set; }
    public byte[] Image { get; set; }
}

public partial class Specialization
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Specialization()
    {
        this.Users = new HashSet<User>();
    }

    public int ID { get; set; }
    public string Name { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<User> Users { get; set; }
}

public partial class User
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public User()
    {
        this.Consultings = new HashSet<Consulting>();
    }

    public int ID { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public Nullable<System.DateTime> DOB { get; set; }
    public string Mobile { get; set; }
    public bool Gender { get; set; }
    public Nullable<int> SpecializationID { get; set; }
    public int UserTypeID { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Consulting> Consultings { get; set; }
    public virtual Specialization Specialization { get; set; }
    public virtual UserType UserType { get; set; }
}

public partial class UserType
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public UserType()
    {
        this.Users = new HashSet<User>();
    }

    public int ID { get; set; }
    public string Name { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<User> Users { get; set; }
}
