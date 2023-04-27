﻿using System;
using System.Collections.Generic;

namespace Universitile01.Models;

public partial class UsersHasAnnouncement
{
    public int AnnouncementsAnnouncementsId { get; set; }

    public byte[] IsRead { get; set; } = null!;

    public string AspnetusersId { get; set; } = null!;

    public virtual Announcement AnnouncementsAnnouncements { get; set; } = null!;

    public virtual Aspnetuser Aspnetusers { get; set; } = null!;
}
